/* Написать программу, которая на вход принимает два числа и выдает (рандомные числа), какое число большее, а какое меньшее */



int number1 = new Random().Next(0, 1000000);
Console.WriteLine(number1);
int number2 = new Random().Next(0, 1000000);
Console.WriteLine(number2);
int max = number1;

if(number2 > max) max = number2;

Console.Write("max = ");
Console.WriteLine(max);