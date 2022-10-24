// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
/*
void Palindrom(string num)
{
    string? numRev=new string(num.ToCharArray().Reverse().ToArray());
    if (num==numRev)
        Console.WriteLine("It is palindrome");
    else
    {
        Console.WriteLine("It is not palindrome");
    }
}

Console.Write("Input a number:");
string? number = Console.ReadLine();
Palindrom(number);
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

/*
double Distance(double x1,double y1,double z1,double x2,double y2,double z2)
{
    double dis=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return dis;
}

Console.WriteLine("Введите кoординаты х1:");
double x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кoординаты y1:");
double y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кoординаты z1:");
double z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кoординаты х2:");
double x2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кoординаты y2:");
double y2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кoординаты z2:");
double z2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты точки 1 ({x1},{y1},{z1}) и точки 2 ({x2},{y2},{z2})");
Console.WriteLine($"Расстояние между точкой1 и1 точкой2 равно: {Distance(x1,y1,z1,x2,y2,z2)}");

*/
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Table (int number)
{
    int index=1;
    while (index<=number)
    {
        double result= Math.Pow(index,3);
        Console.Write(result + " ");
        index++;
    }
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Table(num);
