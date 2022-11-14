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








/*
Console.WriteLine("Input number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());
*/