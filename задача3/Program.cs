// Выяснить является ли число чётным
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine ("число " + num + " чётное");
}
else
{
    Console.WriteLine ("число " + num + " не чётное");
}
