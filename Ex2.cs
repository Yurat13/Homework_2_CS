// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число Х");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число Y");
int y = int.Parse(Console.ReadLine());
if (x == y*y)
{
    Console.WriteLine("Число Х является квадратом Y");
}
else if (y == x*x)
{
    Console.WriteLine("Число Y является квадратом X");
}
else 
{
    Console.WriteLine("Заданные числа не являются квдратом друг друга");
}
