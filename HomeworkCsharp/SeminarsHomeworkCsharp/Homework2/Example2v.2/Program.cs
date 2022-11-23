/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("введите любое целое число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
if(number > 99)
{
while(number > 999) 
{
    number = number / 10;
}
    Console.WriteLine( number % 10);    
}
else
{
    Console.WriteLine("в данном числе нет третьей цифры");
}
