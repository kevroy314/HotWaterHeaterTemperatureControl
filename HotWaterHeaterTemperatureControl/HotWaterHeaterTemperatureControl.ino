#define UP 1
#define DOWN 0

//DIO Variables
const int relayPin =  2; //HIGH means off, LOW means on
int relayState = HIGH; //Default to HIGH/off

//AIO Variables
int sensorPin = A0;

//Temperature Control Variables
const float emergencyCutOffTemp = 210.0; //No matter what, if the temperature is above this, the relay will be off
float targetTemp = 70.0; //The target temperature
float windowSize = 1.0; //The window size to keep the temperature within
float currentTemp = 0.0; //The current temperature from the probe
float movingAverageWindowSize = 25.0; //For smoothing out sensor noise
int autoAdjust = 1; //1 for automatic adjustment, 0 for manual only
int dir = UP;

//Serial I/O Variables
int inByte = 0; //For reading command characters
int bufLength = 256; //Length of character buffer
char* buf = new char[bufLength]; //For reading and writing floats

void setup()
{
  //Start serial interface
  Serial.begin(9600);
  //Set relayPin to output
  pinMode(relayPin, OUTPUT);
  //Write default value
  digitalWrite(relayPin, relayState);
  //Read initial temperature
  currentTemp = getTemp();
  //Set direction
  if(currentTemp<targetTemp) dir = UP;
  else dir=DOWN;
}

void loop()
{
  //Read the current temperature
  currentTemp = (((movingAverageWindowSize-1)/(movingAverageWindowSize))*currentTemp)+(getTemp()*(1/movingAverageWindowSize));
    
  //If we have input
  if (Serial.available() > 0) {
    inByte = Serial.read(); //Read the command byte
    switch(inByte)
    {
      case '0': //Manual Off with '0'
        Serial.write("Manually Turning Off\r\n");
        autoAdjust = 0; //Disable Auto Mode
        relayState = HIGH;
        break;
      case '1': //Manual On with '1'
        Serial.write("Manually Turning On\r\n");
        autoAdjust = 0; //Disable Auto Mode
        relayState = LOW;
        break;
      case 'a': //Enter Automatic Mode with 'a'
        Serial.write("Entering Automatic Mode\r\n");
        autoAdjust = 1; //Enable Auto Mode
        break;
      case 't': //Input New Target Temperature with 'txxx.xxx*'
        Serial.readBytesUntil('*',buf,bufLength);
        targetTemp = atof(buf);
        Serial.write("New Target: ");
        dtostrf(targetTemp,3,1,buf);
        Serial.write(buf);
        Serial.write("\r\n");
        break;
      case 'w': //Set the window size with 'w'
        Serial.readBytesUntil('*',buf,bufLength);
        windowSize = atof(buf);
        Serial.write("New Window Size: ");
        dtostrf(windowSize,3,1,buf);
        Serial.write(buf);
        Serial.write("\r\n");
        break;
      case 'm': //Set the moving average window size with 'm'
        Serial.readBytesUntil('*',buf,bufLength);
        movingAverageWindowSize = atof(buf);
        Serial.write("New Moving Average Window Size: ");
        dtostrf(movingAverageWindowSize,3,1,buf);
        Serial.write(buf);
        Serial.write("\r\n");
        break;
      case 'd': //Display current Temperature/Target
        Serial.write("Current/Target: ");
        dtostrf(currentTemp,3,10,buf);
        Serial.write(buf);
        Serial.write("/");
        dtostrf(targetTemp,3,10,buf);
        Serial.write(buf);
        Serial.write(" : ");
        if(relayState == HIGH) Serial.write("OFF");
        else if (relayState == LOW) Serial.write("ON");
        Serial.write("\r\n");
        break;
      case 'v': //Display a verbose system status
        Serial.write("Current Temperature (degC): ");
        dtostrf(currentTemp,3,10,buf);
        Serial.write(buf);
        Serial.write("\r\n");
        Serial.write("Target Temperature (degC): ");
        dtostrf(targetTemp,3,10,buf);
        Serial.write(buf);
        Serial.write("\r\n");
        Serial.write("Window Size (degC): ");
        dtostrf(windowSize,3,10,buf);
        Serial.write(buf);
        Serial.write("\r\n");
        Serial.write("Moving Average Window Size (samples): ");
        dtostrf(movingAverageWindowSize,3,10,buf);
        Serial.write(buf);
        Serial.write("\r\n");
        Serial.write("Auto Adjust: ");
        if(autoAdjust==0) Serial.write("Disabled");
        else if(autoAdjust==1) Serial.write("Enabled");
        Serial.write("\r\n");
        Serial.write("Current Direction: ");
        if(dir==UP) Serial.write("Up");
        else if(dir==DOWN) Serial.write("Down");
        Serial.write("\r\n");
        break;
//      case 'h': //Display the help menu
//        Serial.write("Commands:\r\n0 - Disable Auto and Turn Off Relay\r\n1 - Disable Auto and Turn On Relay\r\na - Enable Auto Adjust Mode\r\ntxxx.xxxxx* - Set Target Temperature (degC)\r\nwxxx.xxxxx* - Set Window Size (degC)\r\nmxxx.xxxxx* - Set Moving Average Window Size (samples)\r\nd - Display Temperature and Target Temperature\r\nv - Display Verbose Status\r\nh - Display Help\r\n");
//        break;
    }
  }
  
  //Automatic Temperature Control
  if(autoAdjust == 1)
  {
    if(dir==UP)
    {
      if(currentTemp < targetTemp)
        relayState = LOW;
      else
      {
        relayState = HIGH;
        dir = DOWN;
      }
    }
    else if(dir==DOWN)
    {
      if(currentTemp > targetTemp - windowSize)
        relayState = HIGH;
      else
      {
        relayState = LOW;
        dir = UP;
      }
    }
  }

  //Emergency cut-off
  if(currentTemp > emergencyCutOffTemp)
  {
    Serial.write("Emergency Shutoff!");
    relayState = HIGH;
  }
  
  //Write DIO
  digitalWrite(relayPin, relayState); //Write output state
}

//Helper function for getting the temperature of the sensor
float getTemp()
{
  //Assumes 5V input
  return 0.24576 * analogRead(sensorPin) - 20.5128;
}
