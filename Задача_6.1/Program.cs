// Программа, которая на вход принимает число (рандомное) и выдает, является ли число чётным (делится ли оно на два без остатка)



int number = new Random().Next(0, 1000);
Console.WriteLine(number);

if(number % 2 == 0)
{
    Console.WriteLine("Четное число");  
} 
if(number % 2 != 0)
{
    Console.WriteLine("Нечетное число");
}
