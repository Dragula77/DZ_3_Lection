// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введи пятизначное число: ");
string text = Console.ReadLine();
char[] orbtext = text.ToCharArray();
Array.Reverse(orbtext);
string finaltext = new string(orbtext);

if (text.Length == 5)
{
    if (text == finaltext)
    {
        System.Console.WriteLine("Данное число является палиндромом");
    }
    if (text != finaltext)
    {
        Console.WriteLine("Данное число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число!");
}
