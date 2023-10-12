// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using System.Globalization;

int readint(string msg)
{
    System.Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int input)
{
    if (input > 0 && input <= 7)
    {
        return true;
    }
System.Console.WriteLine("Это не день недели!");
return false;
}

int weekDay = readint("Введите день недели >");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        System.Console.WriteLine("Выходной");
    }
    else
    {
        System.Console.WriteLine("Рабочий день");
    }
}