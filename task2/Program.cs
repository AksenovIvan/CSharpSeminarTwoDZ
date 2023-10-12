// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
using System.Globalization;

int readint(string msg)
{
    System.Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int GetThirdRank(int input)
{
    while (input > 999)
    {
        input = input / 10;
    }
    return input % 10;
}

bool ValidateNumber (int input)
{
    if (input < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int input = readint ("Введите число >");
if (ValidateNumber(input))
{
    System.Console.WriteLine(GetThirdRank(input));
}