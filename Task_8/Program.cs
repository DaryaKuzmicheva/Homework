// Программа которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int start = 1;
while(start <= Number)
    {
        if(start % 2 == 0)
        Console.Write(start + ", ");
        start ++;
    }
