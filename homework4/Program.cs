// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Stepen(int a,int b)
{
    int step=1;
    int index=1;
    while(index<=b)
        {
            step=step*a;
            index++;

        }
     return step;
}

Console.WriteLine("input A:");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input B:");
int B=Convert.ToInt32(Console.ReadLine());
if (B<0) 
    {
        Console.WriteLine("Пожалуйста, введите положительное число B.");
    }

    else
    {
        Console.WriteLine($"{A} в степени {B}:{Stepen(A,B)}");
    }
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumDigit(int num)
{
    if (num<0) num=num*-1;
    
    int sum=0;
    int current=num;
    while(current>0)
        {
            sum=sum+current%10;
            current=current/10;
        }
     return sum;
}

Console.WriteLine("input a number:");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} равняется:{SumDigit(number)}");
