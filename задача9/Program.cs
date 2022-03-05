// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (num > 999)
    {
        num = num / 10;        
    }
    num = num % 10;
    Console.WriteLine(num); 
}

