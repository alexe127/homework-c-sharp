// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число из отрезка [10, 99]");
int num = new Random() .Next(10,100);
    Console.WriteLine(num);
int a = num / 10;
Console.WriteLine(a);
int b = num % 10;
Console.WriteLine(b);
if (a>b)
{
    Console.WriteLine("наибольшая цифра числа = "+ a);
}

else
{
    Console.WriteLine("наибольшая цифра числа = "+ b);
}   
