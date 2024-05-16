//Zadanie domowe Dzień 5
int number = 73234566;
string numberToString = number.ToString();
char[] letters = numberToString.ToArray();

Console.WriteLine("Ilość znaków występujących w liczbie: " + number);
for (char sign = '0'; sign <= '9'; sign++)
{
	int counter = 0;
	foreach (var letter in letters)
	{
		if (letter == sign)
		{
			counter += 1;
		}
	}
	Console.WriteLine(sign + " => " + counter);	
}
