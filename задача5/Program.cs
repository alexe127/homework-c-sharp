// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num < 1000)
{
    Console.WriteLine("вторая цифра = "+ num / 10 % 10);
}
else
{
    Console.WriteLine("введите трёхзначное число");
}


// Console.WriteLine("Введите трёхзначное число");
// int num = new Random() .Next(100,1000);
//    Console.WriteLine(num);
//
//    Console.WriteLine("вторая цифра = "+ num / 10 % 10);
