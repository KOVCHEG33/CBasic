//(Arthur Solomon) 2. Написать метод подсчета количества цифр числа.
Console.WriteLine("Enter the number.");
int firstN = int.Parse(Console.ReadLine());
int N = firstN / 10;
int digits = 1;

while (N != 0) 
{
    digits = digits + 1;
    N = N / 10;
}
Console.WriteLine($"Number {firstN} consists of {digits} digits!");
Console.ReadLine();