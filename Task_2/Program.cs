// Программа, которая на вход принимает два числа и выдает какое число большее, а какое меньшее.
Console.WriteLine("Введите число A:");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int NumberB = Convert.ToInt32(Console.ReadLine());
if (NumberA > NumberB)
{
    Console.WriteLine( NumberA+ " > " + NumberB);
}
else if (NumberB > NumberA)
{
    Console.WriteLine( NumberA+ " < " + NumberB);
}
else
{
    Console.WriteLine( NumberA+ " = " + NumberB);
}