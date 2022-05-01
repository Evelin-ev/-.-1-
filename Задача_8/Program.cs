// Напишите программу, которая на вход принимает число(N), а на выходе показывает все чётные числа от 0 до N.



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number - 1;
if(number > 0)
{
    for (int i = 1; i <= number; i++)
    {
    if (i % 2 == 0)
    {
        Console.Write(i);
    if (i < temp)
    {
        Console.Write(",");
    }
    }
    }
}
else
{
    Console.WriteLine("Введено некоректное число!");
}

Console.WriteLine(".");