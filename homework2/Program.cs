// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    int des=num/10;
    int secnumer=des%10;
    return secnumer;
}

Console.Write("Input a triple digits:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Second digit of {num} is {SecondDigit(num)}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

int ThirdDigit(string num)
{
    string? numRev=new string(num.ToCharArray().Reverse().ToArray());
    int numberReverse=Convert.ToInt32(numRev);
    int sot=numberReverse%1000;
    int third=sot/100;
    return third;
}


Console.Write("Input a number:");
string? num = Console.ReadLine();
int length = num.Length;
if (length<3)
{
    Console.WriteLine("There is no third digit ");
}
else
{
    Console.WriteLine($"Third digit of {num} is {ThirdDigit(num)}");
}

*/
