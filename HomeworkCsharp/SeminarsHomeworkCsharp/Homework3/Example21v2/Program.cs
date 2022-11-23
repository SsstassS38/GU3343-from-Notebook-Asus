/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetDis3D(Point firstPoint, Point secondPoint)
{
double distance3D = Math.Sqrt(
Math.Pow(firstPoint.X - secondPoint.X, 2)
+Math.Pow(firstPoint.Y - secondPoint.Y, 2)
+Math.Pow(firstPoint.Z - secondPoint.Z, 2));

return distance3D;
}

int GetNumber(string message)
{
Console.WriteLine(message);
return int.Parse(Console.ReadLine());
}

Point GetPoint()
{
Point point = new Point();

point.X = GetNumber("ВВедите кординаты для x");
point.Y = GetNumber("ВВедите кординаты для y");
point.Z = GetNumber("ВВедите кординаты для z");

return point;
}

Point firstPoint = GetPoint();
Point secondPoint = GetPoint();
double distance = GetDis3D(firstPoint, secondPoint);

Console.WriteLine($"Расстояние между точками равно = {distance}");


class Point
{
public int X { get; set; }
public int Y { get; set; }
public int Z { get; set; }
}
