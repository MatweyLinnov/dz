int secondnumber = 1;

Console.Write("Введите  число N:");
int N = Int32.Parse(Console.ReadLine());
//Console.Write(N);

for(int i = 1; i<N; i++)
{
    if(i % 2==0) 
    {
        Console.Write( i + " ");
    }
}
