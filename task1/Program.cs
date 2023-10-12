//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int readint(string msg)
{
    System.Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int number = readint("Введите трехзначное число ->");
if (number < 1000 && number > 99)
{
    int twoNumbers = number / 10 % 10;
    System.Console.WriteLine(twoNumbers);
    
}
else System.Console.WriteLine("Вы ввели неправильное число");
