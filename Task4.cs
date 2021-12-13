/*
 * (Arthur Solomon) 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
 * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 */
string log = "";
string pass = "";
bool authorized = false;
for (int i = 0; i > -3; i--)
{
    Console.WriteLine("Enter LOGIN please.");
    log = Console.ReadLine();
    Console.WriteLine("Enter PASSWORD please.");
    pass = Console.ReadLine();
    if (log == "root" && pass == "GeekBrains")
    {
        break;
    }
    else
    {
        Console.WriteLine($"Wrong LOGIN or PASSWORD. There are {i + 2} attempts left.");
    }
}
if (log == "root" && pass == "GeekBrains")
{
    Console.WriteLine("You was successfully authorized!");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Enter is BLOCKED!");
    Console.ReadLine();
}

