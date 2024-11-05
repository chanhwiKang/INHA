#define LED_PIN LED_BUILTIN

String ledState;
char mode;
int onTime = 1000;
int offTime = 1000;

void setup() {
  Serial.begin(9600);
  Serial.println("LED ON : o 숫자, LED OFF x 숫자");
  pinMode(LED_PIN, OUTPUT);
}

void loop() {
  while(Serial.available()) {
    mode = Serial.read();
    if (mode == 'o') {
      onTime = Serial.parseInt();
      ledState = "LED ON " + String(onTime) + "ms";
      Serial.println(ledState);
    }
    else if (mode == 'x') {
      offTime = Serial.parseInt();
      ledState = "LED OFF " + String(offTime) + "ms";
      Serial.println(ledState);
    }
    
  }
  digitalWrite(LED_PIN, HIGH);
  delay(onTime);
  digitalWrite(LED_PIN, LOW);
  delay(offTime);

}
