// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число");
double num1 = Convert.ToInt32(Console.ReadLine());
double num2 = Convert.ToInt32(Console.ReadLine());
if (num1 % num2 == 0)
{
    Console.WriteLine ("число " + num1 + " кратно числу " + num2);
}
else
{
    Console.WriteLine ("число " + num1 + " не кратно числу " + num2);
    Console.WriteLine ("остаток от деления " + num1 / num2);

}
