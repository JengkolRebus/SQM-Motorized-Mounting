#include <Servo.h>

int AltMinPwm = 600;
int AltMaxPwm = 2325;

int AzmMinPwm = 590;
int AzmMaxPwm = 2130;

Servo servo_alt, servo_azm;

int posAlt;
int posAzm;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  servo_alt.attach(10);
  servo_azm.attach(11);

}

void loop() {
  // put your main code here, to run repeatedly:
  while(Serial.available() > 0){
    posAlt = Serial.parseInt();
    posAzm = Serial.parseInt();

    posAlt = map(posAlt, 0, 180, AltMinPwm, AltMaxPwm);
    posAzm = map(posAzm, 180, 0, AzmMinPwm, AzmMaxPwm);

    servo_alt.writeMicroseconds(posAlt);
    servo_azm.writeMicroseconds(posAzm);
  }

}
