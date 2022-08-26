// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int n = new Random().Next(1,8);
 Console.WriteLine(n);
if (n == 6 | n == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}
