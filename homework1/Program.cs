//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.//

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
