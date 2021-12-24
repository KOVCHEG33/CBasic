// (Arthur Solomon) 1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//                    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
class Complex
{
    public int a, b;

    public Complex(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    //public string Print()
    //{
    //    string v;
    //    if (b < 0) v = $"{a} - {-b}i";
    //    else v = $"{a} + {b}i";
    //    return v;
    //}
    public override string ToString()
    {
        string v;
        if (b < 0) v = $"{a} - {-b}i";
        else v = $"{a} + {b}i";
        return v;
    }

    public static Complex operator + (Complex X1, Complex X2)
    {
        Complex result;
        result = new (X1.a + X2.a, X1.b + X2.b);
        return result;
    }

    public static Complex operator -(Complex X1, Complex X2)
    {
        Complex result;
        result = new(X1.a - X2.a, X1.b - X2.b);
        return result;
    }

    public static Complex operator *(Complex X1, Complex X2)
    {
        Complex result;
        result = new(X1.a * X2.a - X1.b * X2.b, X1.a * X2.b + X1.b * X2.a);
        return result;
    }
}