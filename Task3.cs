//(Arthur Solomon) 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
int Result = 0;
int n = 1;

while (n != 0)
{
    Console.WriteLine("Enter the number.");
    n = int.Parse(Console.ReadLine());
    if (n > 0)
    {
        double parity = n % 2;
        if (parity != 0)
        {
            Result = Result + n;
        }
    }
}

Console.WriteLine($"The sum of all entered positive odd numbers is {Result}!");
Console.ReadLine();
