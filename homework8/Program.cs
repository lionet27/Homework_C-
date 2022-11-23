int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Array is:");

    for (int i = 0; i < (array.GetLength(0)); i++)
    {
        for (int j = 0; j < (array.GetLength(1)); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

    Console.WriteLine();
}


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void SortMaxArray(int[,]array)
{
    for(int i=0;i<array.GetLength(0);i++)
        for(int j=0;j<array.GetLength(1);j++)
            {
                int maxPosition=j;
                for(int m=j+1;m<array.GetLength(1);m++)
                   if(array[i,m]>array[i,maxPosition]) maxPosition=m;
                int temporary=array[i,j];
                array[i,j]=array[i,maxPosition];
                array[i,maxPosition]=temporary; 
            }
}

Console.WriteLine("Input number of  rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

int[,] myArray=CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
SortMaxArray(myArray);
Show2dArray(myArray);