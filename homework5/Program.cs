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

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int AmountEvenNumber(int[]array)
{
    int current=0;
    for(int i=0; i<array.Length;i++)
        if(array[i]%2==0)
            current++;
    return current;      
}

Console.WriteLine("Input number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
int min=100;
int max=999;

int[] myArray=CreateRandomArray(n,min,max);
ShowArray(myArray);
Console.WriteLine($"Amount even number in array is {AmountEvenNumber(myArray)}");
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int SumOddIndex(int[] array)
{
    int sum=0;
    for(int i=0;i<array.Length;i++)
        if(i%2>0)
            sum=sum+array[i];
    return sum;
}

Console.WriteLine("Input number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

int[] myArray=CreateRandomArray(n,min,max);
ShowArray(myArray);

Console.WriteLine($"Amount numbers with odd index in array is {SumOddIndex(myArray)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomDoubleArray(int size,int minValue,int maxValue)
{
    double[] array=new double[size];
    for(int i=0;i<size;i++)
        array[i]=Math.Round((new Random().Next(minValue, maxValue+1)+new Random().NextDouble()),2);
    
    return array;
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

double DifferenceMaxMin(double[]array)
{
    double min=array[0];
    double max=array[0];
    for(int i=0;i<array.Length;i++)
        if(array[i]>max)
            max=array[i];
        else
        {
            if(array[i]<min)
                min=array[i];
        }
    double difference=Math.Round((max-min),2);
    return difference;
}

Console.WriteLine("Input number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

double[] myArray=CreateRandomDoubleArray(n,min,max);
ShowArrayDouble(myArray);

Console.WriteLine($"Difference between max and min value in array is {DifferenceMaxMin(myArray)}");