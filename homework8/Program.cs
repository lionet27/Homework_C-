
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


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
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
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int IndexMinSumRow(int[,] array)
{
    int indexMinSumRow=0;
    int minSumRow=0;
    for(int j=0;j<array.GetLength(1);j++)
         minSumRow+=array[0,j];

    for(int i=1;i<array.GetLength(0);i++)
        {
        int sumRow=0;
        
        for(int j=0;j<array.GetLength(1);j++)
            sumRow+=array[i,j];

        if(sumRow<minSumRow) 
            {
                indexMinSumRow=i;
                minSumRow=sumRow;
            }
        }
    return indexMinSumRow;
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
Console.WriteLine($"Number of row with minimum sum of elemets is "+ IndexMinSumRow(myArray));
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] MatrixMultiplication(int[,]array1, int[,]array2)
{
    int[,] arrayMultipl = new int[array2.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
        {
            for (int m = 0; m < arrayMultipl.GetLength(0); m++)
                for (int n = 0; n < arrayMultipl.GetLength(1); n++)
                    for (int j = 0, k = 0; j < array1.GetLength(1); j++, k++)
                    {
                        int multiple2elements = array1[m, j] * array2[k, n];
                        arrayMultipl[m, n] += multiple2elements;
                    }
        }
    else Console.WriteLine("It is impossible to multiply matrices!");
    return arrayMultipl;
}

Console.WriteLine("Input number of  rows array1: ");
int r1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns array1: ");
int c1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of  rows array2: ");
int r2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns array2: ");
int c2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

int[,] myArray=CreateRandom2dArray(r1,c1,min,max);
Show2dArray(myArray);

int[,] myArray2=CreateRandom2dArray(r2,c2,min,max);
Show2dArray(myArray2);

int[,] matrixMultipl=MatrixMultiplication(myArray,myArray2);
Show2dArray(matrixMultipl);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArrayTwoDigitNumber(int rows, int columns, int depth)
{
    int[,,] array = new int[rows, columns,depth];
    int size=rows*columns*depth;
    Console.WriteLine($"Nummber of elements in 3dArray: {size}");
    if (size < 90)
    {
        int[] numbers = new int[size];
        int[] bysort = new int[size];
        numbers[0] = 10;
        for (int n = 1; n < size; n++)
            numbers[n] = numbers[n - 1] + 1;

        for (int n = 1; n < size; n++)
            bysort[n] = new Random().Next(1, 100);

        Array.Sort(bysort, numbers);

        int index = 0;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                for (int k = 0; k < depth; k++)
                {
                    array[i, j, k] = numbers[index];
                    index++;
                }
    }
    else Console.WriteLine("It is impossible to create an array of non-repeating two-digit numbers");

    return array;
}

void Show3dArray(int[,,] array)
{
    Console.WriteLine("Array is:");

    for (int i = 0; i < (array.GetLength(0)); i++)
    {
        for (int j = 0; j < (array.GetLength(1)); j++)
            for (int k = 0; k < (array.GetLength(2)); k++)
                Console.Write(array[i, j,k] + $"({i},{j},{k})  ");
        Console.WriteLine();
    }    

    Console.WriteLine();
}

Console.WriteLine("Input number of  rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of depth: ");
int k=Convert.ToInt32(Console.ReadLine());

int[,,] myArray=CreateRandom3dArrayTwoDigitNumber(m,n,k);
Show3dArray(myArray);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateSpiralArray(int rows,int columns)
{
    int[,] array = new int[rows, columns];
    int current=0;
    
    for (int k = 0, l = array.GetLength(1), m = array.GetLength(0); k < (array.GetLength(1) / 2 + 1); k++, l--, m--)
    {
        for (int j = k; j < l; j++)
        {
            int i = k;
            array[i, j] = current + 1;
            current++;
        }
        for (int i = k + 1; i < m; i++)
        {
            int j = l - 1;
            array[i, j] = current + 1;
            current++;
        }
        for (int j = l - 2; j >= k; j--)
        {
            int i = m - 1;
            array[i, j] = current + 1;
            current++;
        }
        for (int i = m - 2; i > k; i--)
        {
            int j = k;
            array[i, j] = current + 1;
            current++;
        }
    }

    return array;    
}

Console.WriteLine("Input number of  rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] spiralArray=CreateSpiralArray(m,n);
Show2dArray(spiralArray);

