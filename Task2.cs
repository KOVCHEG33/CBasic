// (Arthur Solomon) 2. С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
// Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
int Result = 0;
int n = 1;
bool flag = false;

while (n != 0)
{
    Console.WriteLine("Enter the number. Type 0 to STOP.");
    do
    {
        flag = int.TryParse(Console.ReadLine(), out n);
        if (n > 0)
        {
            double parity = n % 2;
            if (parity != 0)
            {
                Result = Result + n;
            }
        }
    if (!flag) Console.WriteLine("ASKED you to enter the NUMBERS!");
    } while (!flag);
}

Console.WriteLine($"The sum of all entered positive odd numbers is {Result}!");
Console.ReadLine();