Console.Write("Введите первое число:");
int number1 = Int32.Parse(Console.ReadLine());
Console.WriteLine(number1);

Console.Write("Введите второе число:");
int number2 = Int32.Parse(Console.ReadLine());
Console.WriteLine(number2);

Console.Write("Введите третье число:");
int number3 = Int32.Parse(Console.ReadLine());
Console.WriteLine(number3); 

int max = number1;

if (number1 > number2)
{
    if (number1> number3)
    max = number1;
}


if (number2 > number3)
{
    if (number2 > number1)
    max = number2;
}

if (number3 > number1)
{
    
if (number3 > number2)
    max = number3;
}

Console.Write("Max = ");
Console.WriteLine(max);