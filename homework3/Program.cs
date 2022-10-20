// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

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

