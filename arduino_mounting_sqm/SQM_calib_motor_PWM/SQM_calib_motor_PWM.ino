#include <Servo.h>
//
////int AltMinPwm = 600;
////int AltMaxPwm = 2325;
//
//int AzmMinPwm = 600;
//int AzmMaxPwm = 2125;
//
//int sudut;

Servo servo_alt, servo_azm;
int alt = 0;
int posAlt;
int posAzm;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  //servo_alt.attach(10);
  servo_azm.attach(11);
}

void loop() {
  // put your main code here, to run repeatedly:
  while(Serial.available() > 0){
    //posAlt = Serial.parseInt();
    posAzm = Serial.parseInt();
    Serial.print("Azm =");
    Serial.print(posAzm);
    //posAlt = map(posAlt, 0, 180, AltMinPwm, AltMaxPwm);
    //posAzm = map(posAzm, 180, 0, AzmMinPwm, AzmMaxPwm);
    
    //servo_alt.writeMicroseconds(posAlt);
    servo_azm.writeMicroseconds(posAzm);

//    Serial.print("Alt =");
//    Serial.print(posAlt);
//    Serial.print('\t');
//    Serial.print(servo_alt.readMicroseconds());
//    
//    Serial.print('\t');
    
    
    Serial.print('\t');
    Serial.println(servo_azm.readMicroseconds());
    
  }
}
