// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    int des=num/10;
    int secnumer=des%10;
    return secnumer;
}

Console.Write("Input a triple digits:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Second digit of {num} is {SecondDigit(num)}");

