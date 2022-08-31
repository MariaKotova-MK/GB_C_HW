// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите 1 число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int z = Convert.ToInt32(Console.ReadLine());

int max = x;

if (max>y)
{
    if (max>z)
    Console.WriteLine("Максимальное число " +max);
}
else max = y;
if (max>z)
{
    Console.WriteLine("Максимальное число " +max);
}
else Console.WriteLine("Максимальное число " +z);
