Console.WriteLine("Введите количество чисел:");
        int n = int.Parse(Console.ReadLine()!);
        int[] Numbers = new int[n];
        int i = 0;
        while(i < n)
        {
            Console.WriteLine($"Введите {i + 1}-е число:");
            Numbers[i] = int.Parse(Console.ReadLine()!);
            i++;
        }
        

        int MaxNumberIndex = 0;
        int Index = 0;

        while (Index < n)
        {
            if (Numbers[Index] > Numbers[MaxNumberIndex])
            {
                MaxNumberIndex = Index;
            }
            Index++;
        }

        Console.WriteLine($"Максимальное число: {Numbers[MaxNumberIndex]}");
   


