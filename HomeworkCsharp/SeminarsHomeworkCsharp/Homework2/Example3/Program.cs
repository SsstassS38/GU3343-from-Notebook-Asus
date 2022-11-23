/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number == 1) Console.WriteLine ("Данный день недели понедельник - рабочий");
if (number == 2) Console.WriteLine ("Данный день недели вторник - рабочий");
if (number == 3) Console.WriteLine ("Данный день недели среда - рабочий");
if (number == 4) Console.WriteLine ("Данный день недели четверг - рабочий");
if (number == 5) Console.WriteLine ("Данный день недели пятница - рабочий");
if (number == 6) Console.WriteLine ("Данный день недели суббота - выходной");
if (number == 7) Console.WriteLine ("Данный день недели воскресенье - выходной");