// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int readint(string msg)
{
    System.Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int number = readint("Введите число обозначающее день недели (от 1 до 7)->");
if (number == 1)
{
System.Console.WriteLine("Будний день");
}
else
System.Console.WriteLine("Выходной день");