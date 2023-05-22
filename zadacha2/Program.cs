int FirstNumber;
int SecondNumber;

Console.Write("введите число 1: ");
FirstNumber = int.Parse(Console.ReadLine()!);

Console.Write("введите число 2: ");
SecondNumber = int.Parse(Console.ReadLine()!);

if (FirstNumber > SecondNumber)
{
    Console.Write("max = ");
    Console.WriteLine(FirstNumber);
    Console.Write("min = ");
    Console.WriteLine(SecondNumber);
}
else 
{
    Console.Write("max = ");
    Console.WriteLine(SecondNumber);
    Console.Write("min = ");
    Console.WriteLine(FirstNumber);
}

