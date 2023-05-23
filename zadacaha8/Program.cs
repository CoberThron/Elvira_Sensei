Console.WriteLine("Введите число:");
int Number = int.Parse(Console.ReadLine()!);    
Console.WriteLine($"Чётные числа от 1 до {Number}:");
int Count = 2;
while (Count <= Number)             
{
 Console.WriteLine(Count);
 Count += 2;
}

