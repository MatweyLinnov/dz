
int number1 = new Random().Next(0, 10);
int number2 = new Random().Next(0, 10);

Console.WriteLine(number1);
Console.WriteLine(number2);

int max = number1;

if (number1 > number2)
{
   max = number1;
}

else 
{
    max = number2;
}

Console.Write("Max = ");
Console.WriteLine(max);


