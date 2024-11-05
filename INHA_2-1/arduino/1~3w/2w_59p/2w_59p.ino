#define LED_PIN LED_BUILTIN
#define LED_ON HIGH
#define LED_OFF LOW


void setup() {
  Serial.begin(9600);
  Serial.println("==========\n");
  pinMode(LED_PIN, OUTPUT);
}
String inputVal;
int ledVal;
// the loop function runs over and over again forever
void loop() {
  inputVal = Serial.readString();

  if(inputVal == "on") {
    Serial.println("LED ON");
    ledVal = LED_ON;
  }
  else if(inputVal == "off") {
    Serial.println("LED OFF");
    ledVal = LED_OFF;
  }
  digitalWrite(LED_PIN, ledVal);
}
