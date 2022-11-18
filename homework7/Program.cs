//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dDoubleArray(int rows,int columns, int minValue,int maxValue)

{
    double[,] array=new double[rows,columns];

    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            array[i,j]=Math.Round((new Random().Next(minValue, maxValue+1)+new Random().NextDouble()),2);
    
    return array;
}

void Show2dDoubleArray(double[,]array)
{
        Console.WriteLine("Array is:");

    for(int i=0; i<(array.GetLength(0)); i++)
    {
        for(int j=0; j<(array.GetLength(1)); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    
    Console.WriteLine();
}

Console.WriteLine("Input number of  rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

double[,] myArray=CreateRandom2dDoubleArray(m,n,min,max);
Show2dDoubleArray(myArray);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows,int columns, int minValue,int maxValue)
{
    int[,] array=new int[rows,columns];

    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            array[i,j]=new Random().Next(minValue, maxValue+1);
    
    return array;
}

void Show2dArray(int[,]array)
{
        Console.WriteLine("Array is:");

    for(int i=0; i<(array.GetLength(0)); i++)
    {
        for(int j=0; j<(array.GetLength(1)); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    
    Console.WriteLine();
}