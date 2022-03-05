// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int num = new Random() .Next(100,1000);
    Console.WriteLine(num);
int a = num / 100;

int b = num % 10;

Console.Write(a);
Console.Write(b);

