// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второe целое число");
int b = Convert.ToInt32(Console.ReadLine());
    if (a>b) 
    {
        Console.WriteLine("Макисмальное число "+a);
    } 
    else if (b>a)
    {
        Console.WriteLine("Максимальное число "+b);
    }
        else Console.WriteLine("Числа равны");