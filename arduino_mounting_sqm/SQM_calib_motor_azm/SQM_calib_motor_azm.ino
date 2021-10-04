#include <Servo.h>

//int AltMinPwm = 600;
//int AltMaxPwm = 2325;

int halfB_AzmMinPwm = 1358;
int halfB_AzmMaxPwm = 2135;

int halfT_AzmMinPwm = 615;
int halfT_AzmMaxPwm = 1267;

Servo servo_azm;
int posAzm;
int input;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  servo_azm.attach(11);
}

void loop() {
  // put your main code here, to run repeatedly:
  while(Serial.available() > 0){
    input = Serial.parseInt();
    
      //posAzm = map(input, 180, 100, halfT_AzmMinPwm, halfT_AzmMaxPwm);
      //posAzm = 0.0084*(input*input) - (10.502*input) + 2232.5;
      posAzm = 0.0029*(input*input) - (8.9987*input) + 2134.3;
    Serial.print(input);
    servo_azm.writeMicroseconds(posAzm);
    Serial.print('\t');
    Serial.println(servo_azm.readMicroseconds());
    
  }
}
