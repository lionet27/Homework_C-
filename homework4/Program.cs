// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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
