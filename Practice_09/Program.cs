//Задача 63: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от 1 до N.

string Number(int a, int b)
{
    if (a <= b)
    {
        return $"{a} " + Number(a + 1, b);
    }
    else
    {
        return string.Empty;
    }
}

System.Console.WriteLine("Задайте ваше число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Вывод всех натуральных чисел от 1 до заданого числа: ");
System.Console.WriteLine(Number(1, b));

//Задача 65: Задайте значения M и N. Напишите программу, которая выведет
//все натуральные числа в промежутке от M до N.

string Number(int a, int b)
{
    if (a <= b)
    {
        return $"{a} " + Number(a + 1, b);
    }
    else
    {
        return string.Empty;
    }
}

System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Number(m, n));

int Factorial(int a)
{
    if (a == 1)
    {
        return 1;
    }
    return a * Factorial(a - 1);
}

System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("факториал числа N:");
System.Console.WriteLine(Factorial(n));

// Задача 67: Напишите программу, которая будет принимать на вход число 
//и возвращать сумму его цифр.

int Addition(int a)
{
    if (a == 0)
    {
        return 0;
    }
    else
    {
        return a % 10 + (Addition(a / 10));
    }
}

System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Сумма цифр числа: " + (Addition(n)));

// Задача 69: Напишите программу, которая принимает на вход два числа и
// возводит число А в целую степень В с помощью рекурсии.

int PowNumber(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    return a * PowNumber(a, b - 1);
    
}
System.Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Число А возведеное в степень числа В : ");
System.Console.WriteLine(PowNumber(a, b));