#include <Wire.h> // Biblioteca utilizada para fazer a comunicação com o I2C
#include <LiquidCrystal_I2C.h> // Biblioteca utilizada para fazer a comunicação com o display 20x4
 

#define col 16
#define lin 2
#define endereco 0x27

LiquidCrystal_I2C lcd(endereco, col, lin);

//variavel para escolher a porta
int sensorMagnetico = 3;

int count = 0;
float ml = 0.4, total = 0;

void setup() 
{
    lcd.init();
    lcd.backlight();
    lcd.clear();


    Serial.begin(9600);
    pinMode(sensorMagnetico, INPUT);
}

void loop() 
{
//
    if(digitalRead(sensorMagnetico) == HIGH)
    {
      count++;
      total += count * ml;  
    }
    
    //Serial.print("Conta pingo: %d", count);
    //Serial.print("Conta mL: %d", ml);
    
    lcd.setCursor(1,0);
    lcd.print("Quantidade:");

    lcd.setCursor(1,1);
    lcd.print("CONTADOR: %i");
    lcd.print(count);
}