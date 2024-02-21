int buttonState;      // volgende led knop
int ledCount = 10;    // 10 is begin getal
int btnVolgorde;      // draai volgorde om knop
bool volgorde = true; // true is 11,12,13 false is 13,12,11

void setup()
{
  // standaard dingen
  Serial.begin(9600);
  pinMode(2, INPUT);
  pinMode(5, INPUT);
  pinMode(11, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(13, OUTPUT);
}

void loop()
{ 
  
  // buttons aflezen
  btnVolgorde = digitalRead(5); // draai volgorde om - knop
  buttonState = digitalRead(2); // volgende led waarde - knop
 
  
  // draai volgorde om button pulse converter
  if (btnVolgorde == HIGH)
  {
    while (btnVolgorde == HIGH) // HIGH
    {
      btnVolgorde = digitalRead(5); 
    } 
    
    // volgorde omdraaien
    volgorde = !volgorde;
    Serial.println("Volgorde omgedraaid!");     
  }
  
  
  // Volgende led button pulse converter
  if (buttonState == HIGH)
  {  
    while (buttonState == HIGH) // HIGH
    {
      buttonState = digitalRead(2); 
    } 
   
    
    // 11, 12, 13 volgorde
    if (volgorde)
    {
      
      if(ledCount == 13) // 13 is hoogst dus reset naar 10
      {
        ledCount = 10;
      }
      
      ledCount++;
      Serial.println(ledCount);
    
      if (ledCount == 11)
      {
        digitalWrite(11, HIGH);
        digitalWrite(13, LOW);
      }
    
      if (ledCount == 12)
      {  
        digitalWrite(12, HIGH);
        digitalWrite(11, LOW);
      }
    
      if (ledCount == 13)
      {
        digitalWrite(13, HIGH);
        digitalWrite(12, LOW);
      }
    }
  
    
    // 13, 12, 11 volgorde
    if (!volgorde)
    {   
      if(ledCount == 11) // 11 is laagst dus reset naar 14
      {
        ledCount = 14;
      }
      
      ledCount--;
      Serial.println(ledCount);      
      
      if (ledCount == 13)
      {
        digitalWrite(13, HIGH);
        digitalWrite(11, LOW);
      }
    
      if (ledCount == 12)
      {  
        digitalWrite(12, HIGH);
        digitalWrite(13, LOW);
      }
    
      if (ledCount == 11)
      {
        digitalWrite(11, HIGH);
        digitalWrite(12, LOW);
      }
    }
  }
}
