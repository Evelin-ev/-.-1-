/* Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее */



Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number2 > max) max = number2;

Console.Write("max = ");
Console.WriteLine(max);


