int[] CreateRandomArray(int size,int minValue,int maxValue)
{
    int[] array=new int[size];
    for(int i=0;i<size;i++)
        array[i]=new Random().Next(minValue, maxValue+1);
    
    return array;
}

void ShowArray(int[]array)
{
        Console.Write("Array is:[");

    for(int i=0; i<(array.Length-1); i++)
    {
        Console.Write(array[i] + " ");
        Console.Write(",");
    }
    Console.WriteLine(array[array.Length-1]+ "]");
}

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)