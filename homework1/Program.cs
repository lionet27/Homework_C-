//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.//
/*
Console.Write("Input a first number: ");
int n1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2=Convert.ToInt32(Console.ReadLine());
int max=0;
int min=0;

if (n1>n2)
{
    max=n1;
    min=n2;
    }
else
{
    max=n2;
    min=n1;
}
Console.WriteLine($"Number {max} is the biigest and number {min} is the smallest");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.//

/* 
Console.Write("Input a first number: ");
int n1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int n3=Convert.ToInt32(Console.ReadLine());

int max=n1;

if (n2>max) max=n2;
if (n3>max) max=n3;

Console.Write("max=");
Console.WriteLine(max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).//

Console.Write("Введите число:");
int num =Convert.ToInt32(Console.ReadLine());

if (num%2==0)
    {
        Console.WriteLine($"Число {num} четное");
    }
else 
    {
        Console.WriteLine($"Число {num} нечетное");
    }

