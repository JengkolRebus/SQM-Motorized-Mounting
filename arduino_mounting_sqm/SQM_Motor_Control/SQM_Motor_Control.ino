#include <Servo.h>

Servo servo_alt, servo_azm;
int inputAzm, inputAlt, posAlt, posAzm, gotoAlt, gotoAzm;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  servo_azm.attach(11);
  servo_alt.attach(10);

}

void loop() {
  // put your main code here, to run repeatedly:
  while(Serial.available() > 0){
    inputAlt = Serial.parseInt();
    inputAzm = Serial.parseInt();

    if(inputAzm >= 181){
      gotoAzm = map(inputAzm, 360, 180, 180, 0);
      gotoAlt = map(inputAlt, 180, 0, 0, 180);
    }

    else{
      gotoAzm = inputAzm;
      gotoAlt = inputAlt;
    }

    //persamaan polinomial Motor Altitude, y = 0.0045(x^2) + 8.5245(x) + 596.66
    posAlt = 0.0045*(gotoAlt*gotoAlt) + (8.5245*gotoAlt) + 596.66;

    //persamaan polinomial Motor Altitude, y = 0.0029(x^2) - 8.9987(x) + 2134.3
    posAzm = 0.0029*(gotoAzm*gotoAzm) - (8.9987*gotoAzm) + 2134.3;

//    Serial.print(gotoAlt);
//    Serial.print("\t");
//    Serial.println(gotoAzm);
    servo_alt.writeMicroseconds(posAlt);
    servo_azm.writeMicroseconds(posAzm);
  }

}
