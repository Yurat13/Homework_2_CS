// Найти расстояние между точками в пространстве 2D
Console.WriteLine("Введите точку (x1, y1)");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку (x2, y2)");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2-x1, x2-x1) + Math.Pow(y2-y1, y2-y1));
Console.WriteLine(result);