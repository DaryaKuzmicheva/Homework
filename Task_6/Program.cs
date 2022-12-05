// Программа которая на вход принимает число и выдает является ли число четным.
int x;
Console.WriteLine("Введите число");
x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine("-> Да");
}
else
{
    Console.WriteLine("-> Нет");
}