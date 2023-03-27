//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введи 2 числа");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (b > a)
        {
            Console.WriteLine($"Max: {b} Min: {a}");
        }
        else if (b < a)
        {
            Console.WriteLine($"Max: {a} Min: {b}");
        }
        else
        {
            Console.WriteLine("Ошибка, числа равны");
        }
    }
}