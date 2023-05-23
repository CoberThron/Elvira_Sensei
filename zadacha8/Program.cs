Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);    // Считываем число N

Console.WriteLine($"Чётные числа от 1 до {n}: ");

for (int i = 2; i <= n; i += 2)             // Используем цикл для перебора чётных чисел
{
    Console.WriteLine(i);
}    
