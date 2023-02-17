int n[10]; //array of 10
void setup()
{

}

void loop()
{
	for(int i=0; i<10; ++i)
	{
		n[i]= 0;
		Serial.print(i);
		Serial.print('\r');
	} 
	for (int j = 0; j < 10; ++j)
	{
		Serial.print(n[j]);
		Serial.print('\r');	}
}