Console.WriteLine("Введите число: ");
int Numbers = int.Parse(Console.ReadLine()!);    

Console.WriteLine($"Чётные числа от 1 до {Numbers}: ");
int Count = 2;

while (Count <= Numbers)             
{
    Console.WriteLine(Count);
    Count += 2;
}   
 