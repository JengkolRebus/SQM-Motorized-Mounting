#include <Servo.h>

Servo servo_alt, servo_azm;
int inputAzm, inputAlt, posAlt, posAzm, gotoAlt, gotoAzm;

//int azm;
int pos_alt = 0;
int pos_azm = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  servo_alt.attach(10);
  servo_azm.attach(11);

}

void loop() {
  // put your main code here, to run repeatedly:
  while ( Serial.available() > 0) {
    inputAlt = Serial.parseInt();
    inputAzm = Serial.parseInt();

    if(inputAzm >= 181){
      gotoAzm = map(inputAzm, 360, 180, 180, 0);
      gotoAlt = map(inputAlt, 180, 0, 0, 180);
    } else{
      gotoAzm = inputAzm;
      gotoAlt = inputAlt;
    }
    
    pos_alt = servo_alt.readMicroseconds();
    Serial.print(pos_alt);
    Serial.print("\t");
    pos_azm = servo_azm.readMicroseconds();
    Serial.println(pos_azm);
    
    posAlt = 0.0045*(gotoAlt*gotoAlt) + (8.5245*gotoAlt) + 596.66;
    posAzm = 0.0029*(gotoAzm*gotoAzm) - (8.9987*gotoAzm) + 2134.3;
    
    
    if(posAlt > pos_alt){
      for(pos_alt = pos_alt; pos_alt <= posAlt; pos_alt +=1){
        servo_alt.writeMicroseconds(pos_alt);
        delay(1);
      }
    }
    if(posAlt < pos_alt){
      for(pos_alt = pos_alt; pos_alt >= posAlt; pos_alt -=1){
        servo_alt.writeMicroseconds(pos_alt);
        delay(1);
      }
    }
    
    if(posAzm > pos_azm){
      for(pos_azm = pos_azm; pos_azm <= posAzm; pos_azm +=1){
        servo_azm.writeMicroseconds(pos_azm);
        delay(1);
      }
    }
    if(posAzm < pos_azm){
      for(pos_azm = pos_azm; pos_azm >= posAzm; pos_azm -=1){
        servo_azm.writeMicroseconds(pos_azm);
        delay(1);
      }
    }

    
  }

  

}
