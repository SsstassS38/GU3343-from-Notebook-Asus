/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
String number = Console.ReadLine();
int pall = number.Length;
if (pall == 5)
{
    if(number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Данное число являтся палиндромом");
    }
    else
    {   
        Console.WriteLine("Данное число не палиндром");
    }
}

