// Программа которая принимает на вход три числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int NumberC = Convert.ToInt32(Console.ReadLine());
int max = NumberA;
if (NumberA > max) max = NumberA;
if (NumberB > max) max = NumberB;
if (NumberC > max) max = NumberC;
Console.WriteLine ("Max =");
Console.WriteLine (max);