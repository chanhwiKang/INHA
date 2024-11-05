LED_PIN LED_BUILTIN ;
void setup() {
  // put your setup code here, to run once:
  pinMode(LED_PIN, OUPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(LED_PIN, HIGH);
  delay(1500);
  digitalWrite(LED_PIN, LOW);
  delay(500);
}
