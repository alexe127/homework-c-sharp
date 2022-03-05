// задача 2 Найти максимальное из трёх чисел

    int Max(int num1, int num2, int num3)
    {
        int result = num1;
        if (num2 > result) result = num2;
        if (num3 > result) result = num3;
        return result;
    }
    int a = new Random() .Next(1,1000);
    Console.WriteLine(a);
    int b = new Random() .Next(1,1000);
    Console.WriteLine(b);
    int c = new Random() .Next(1,1000);
    Console.WriteLine(c);

    int max = Max(a, b, c);
    Console.WriteLine("Максимальное из трёх чисел: " + max);
