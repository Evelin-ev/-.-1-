/* Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее */



Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number2;

if(number2 > number1) max = number2;
if(number2 > number1) min = number1;

Console.Write("большее число = ");
Console.WriteLine(max);

Console.Write("меньшее число = ");
Console.WriteLine(min);
