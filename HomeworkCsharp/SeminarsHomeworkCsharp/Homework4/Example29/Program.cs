/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();
*/
Console.Write("Введите массив 8 чисел через запятую: ");
string numberStr = Console.ReadLine();
string[] array = numberStr.Split();  
Console.Write("[");
for (int i = 0; i < array.Length-1; i++)
Console.Write(array[i]+", ");
Console.WriteLine(array[array.Length-1]+"]");


