
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*

int QuantityPositive(int m)
{
    int positive=0;
    for (int count=1; count<=m;count++)
    {
       Console.WriteLine("Input a number: ");
       int x=Convert.ToInt32(Console.ReadLine()); 
       if (x>0) positive++; 
    }
    return positive;
}

Console.WriteLine("Input number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number of pozitive elements is "+QuantityPositive(n));

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Input b1: ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1: ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2=Convert.ToDouble(Console.ReadLine());

if(k1==k2)
    {
        if(b1==b2)
            Console.WriteLine("Прямые совпадают");
        else
            Console.WriteLine("Прямые параллельные");
    }
else 
    {
        double x=Math.Round(((b2-b1)/(k1-k2)),2);
        double y=k1*x+b1;

        Console.WriteLine($"Intersection point of two lines is x={x},y={y} ");
    }

