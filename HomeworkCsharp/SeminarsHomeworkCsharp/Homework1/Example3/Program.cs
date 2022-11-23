/*Напишите программу, которая на вход принимает число и выдаёт, является ли число 
чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число: ");
string numberA = Console.ReadLine() ??"";
int number = int.Parse(numberA);
int result = (number % 2);

if(result == 0)
    {
        Console.WriteLine("число является четным ");
    }   
else
    {
        Console.WriteLine("число не четное ");
    };
