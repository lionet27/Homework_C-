//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
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
*/
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


// Решение через 2 метода. Проверки наличия элемента и вывода его значения при наличии. 

/*
bool IsThereElement(int[,]array,int i,int j)

{
    if (i<(array.GetLength(0))&&j<(array.GetLength(1)))
        return true;
    else
        return false;
}

int ElementIJ(int[,]array,int i,int j)
{
    int element=array[i,j];
    return element;
}

Console.WriteLine("Input number of  rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input idex of  row: ");
int i=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input index of column: ");
int j=Convert.ToInt32(Console.ReadLine());

int[,] myArray=CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine($"There is Element[{i},{j}] in array.It is "+IsThereElement(myArray,i,j));
if (IsThereElement(myArray,i,j)==true)
    {
        int elementij=ElementIJ(myArray,i,j);
        Console.WriteLine($"Element[{i},{j}]={elementij}");
    }

*/
//Решение через void метод.
/*
void ShowElementIJ(int[,]array, int i, int j)

{
    if (i<(array.GetLength(0))&&j<(array.GetLength(1)))
        Console.WriteLine($"Element[{i},{j}]={array[i,j]}");
    else
        Console.WriteLine($"There is no element[{i},{j}].");
}
Console.WriteLine("Input number of  rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input idex of  row: ");
int i=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input index of column: ");
int j=Convert.ToInt32(Console.ReadLine());

int[,] myArray=CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
ShowElementIJ(myArray,i,j);
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[] EverageInColumns(int[,]array)
{
    double[]resultArray=new double[array.GetLength(1)];
    for(int j=0; j<(array.GetLength(1)); j++)
    {
        double sumColumn=0;
        for(int i=0; i<(array.GetLength(0)); i++)
            sumColumn+=array[i,j];
        resultArray[j]=Math.Round((sumColumn/array.GetLength(0)),2);
    }
    return resultArray;
}

void ShowArrayDouble(double[]array)
{
        Console.Write("Array is:[");

    for(int i=0; i<(array.Length-1); i++)
    {
        Console.Write(array[i] + " ");
        Console.Write(",");
    }
    Console.WriteLine(array[array.Length-1]+ "]");
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
double[] everegeArray=EverageInColumns(myArray);
Console.WriteLine("Everege of column are in a following array.");
ShowArrayDouble(everegeArray);
