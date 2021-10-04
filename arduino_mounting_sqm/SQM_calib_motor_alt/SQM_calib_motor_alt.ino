#include <Servo.h>

int AltMinPwm = 600;
int AltMaxPwm = 2275;

//int halfB_AzmMinPwm = 1358;
//int halfB_AzmMaxPwm = 2135;
//
//int halfT_AzmMinPwm = 615;
//int halfT_AzmMaxPwm = 1267;

Servo servo_alt;
int posAlt;
int input;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  servo_alt.attach(10);
}

void loop() {
  // put your main code here, to run repeatedly:
  while (Serial.available() > 0) {
    input = Serial.parseInt();

    //posAlt = map(input, 0, 180, AltMinPwm, AltMaxPwm);
    //posAzm = 0.0084*(input*input) - (10.502*input) + 2232.5;
    //posAzm = 0.0029*(input*input) - (8.9987*input) + 2134.3;
    posAlt = 0.0045*(input*input) + (8.5245*input) + 596.66;
    Serial.print(input);
    servo_alt.writeMicroseconds(posAlt);
    Serial.print('\t');
    Serial.println(servo_alt.readMicroseconds());

  }
}
