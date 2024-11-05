const int IN[4] = {6,5,4,3};
int cnt = 1;
void setup() {
  for(int i=0;i<2;i++){
    pinMode(IN[i], OUTPUT);
  }
}
void loop() {
 Stop(1500);
 Forward(1500);
 Backward(1500);
}
void Stop(int i){
  digitalWrite(IN[0], 0);
  digitalWrite(IN[2], 0);
  digitalWrite(IN[1], 0);
  digitalWrite(IN[3], 0);
  delay(i);
}

void Forward(int i){
  digitalWrite(IN[0], 1);
  digitalWrite(IN[2], 1);
  digitalWrite(IN[1], 0);
  digitalWrite(IN[3], 0);
  delay(i);
}

void Backward(int i){
  digitalWrite(IN[0], 0);
  digitalWrite(IN[2], 0);
  digitalWrite(IN[1], 1);
  digitalWrite(IN[3], 1);
  delay(i);
}

void Left(int i){
  digitalWrite(IN[0], 1);
  digitalWrite(IN[2], 0);
  digitalWrite(IN[1], 0);
  digitalWrite(IN[3], 0);
  delay(i);
}

void Right(int i){
  digitalWrite(IN[0], 0);
  digitalWrite(IN[2], 1);
  digitalWrite(IN[1], 0);
  digitalWrite(IN[3], 0);
  delay(i);
}