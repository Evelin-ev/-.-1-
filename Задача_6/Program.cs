// Программа, которая на вход принимает число и выдает, является ли число чётным (делится ли оно на два без остатка)



Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Четное число");  
} 
if(number % 2 != 0)
{
    Console.WriteLine("Нечетное число");
}

