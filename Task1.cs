//(Arthur Solomon) 1. Написать метод, возвращающий минимальное из трёх чисел. 

Console.WriteLine("Enter the first number.");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number.");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number.");
int c = int.Parse(Console.ReadLine());

if (a < b && a < c)
{
    Console.WriteLine($"The smallest number is {a}!");
    Console.ReadLine();
}
else if (b < a && b < c)
{
    Console.WriteLine($"The smallest number is {b}!");
    Console.ReadLine();
}
else
{
    Console.WriteLine($"The smallest number is {c}!");
    Console.ReadLine();
}