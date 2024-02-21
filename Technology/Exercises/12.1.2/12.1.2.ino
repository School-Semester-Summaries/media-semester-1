const int BTN1 = 7; // Button 1
const int BTN2 = 5; // Button 2
const int BTN3 = 2; // Button 3

const int ledg = 9;  // Groene LED
const int ledb = 10; // Blauwe LED
const int ledr = 11; // Rode LED

const int arraySize = 3; // Aantal array values
int array[arraySize] = {0,0,0}; // Array
int count = 0; // Aantal button presses

void setup() 
{
  Serial.begin(9600);
  
  // INPUTS
  pinMode(BTN3, INPUT);
  pinMode(BTN2, INPUT);
  pinMode(BTN1, INPUT);
  
  // OUTPUTS
  pinMode(ledg, OUTPUT);
  pinMode(ledb, OUTPUT);
  pinMode(ledr, OUTPUT);
}

void loop() 
{
  
  // Button 3
  if (digitalRead(BTN3) == HIGH)
  {
    while (digitalRead(BTN3) == HIGH){}
  
    Serial.println("BTN3"); // Check of t werkt
    
    // Button 3 - array waarde
    array[count++] = ledg;
  }
      
  // Button 2
  if (digitalRead(BTN2) == HIGH)
  {
    while (digitalRead(BTN2) == HIGH){}
  
    Serial.println("BTN2"); // Check of t werkt
    
    // Button 2 - array waarde
    array[count++] = ledb;
  }
  
   // Button 1
  if (digitalRead(BTN1) == HIGH)
  {
    while (digitalRead(BTN1) == HIGH){}
  
    Serial.println("BTN1"); // Check of t werkt
    
    // Button 1 - array waarde
    array[count++] = ledr;
  }
  
  // 3 keer geklikt
  if (count == arraySize)
  {
    Serial.println("Kijk leds");
    
    for (count = 0; 3 > count; count++)
    {
      delay(300);
      digitalWrite(array[count], HIGH);
      delay(300);
      digitalWrite(array[count], LOW);
    }    
    
    count = 0;
  }
}
