// (Arthur Solomon)
// 1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
Complex X1 = new(-1, -2);
Console.WriteLine(X1);

Complex X2 = new(-3, -4);
Console.WriteLine(X2);

Complex Sum;
Sum = X1 + X2;
Console.WriteLine($"Summation = {Sum}");

Complex Sub;
Sub = X1 - X2;
Console.WriteLine($"Subtraction = {Sub}");

Complex Mult;
Mult = X1 * X2;
Console.WriteLine($"Multiplication = {Mult}");
Console.ReadLine ();