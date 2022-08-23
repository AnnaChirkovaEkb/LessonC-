
/*
//1.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//a < b + c

bool FindNoName (int a, int b,int c)
{
    if (a<b+c && b<a+c && c<a+b)
    return true;
    else return false;
    
}

Console.WriteLine("Длина первой стороны: ");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Длина второй стороны: ");
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Длина третьей стороны: ");
int c=Convert.ToInt32(Console.ReadLine());

if (FindNoName(a,b,c)) Console.WriteLine ("Треугольник");
else Console.WriteLine ("Не треугольник");

*/

//2.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

void Febonacci(int a,int b, int N)
{
    int c;
    Console.Write (a+" "+b+" ");
    for (int i=2; i<N; i++)
    {
        c=a+b;
        Console.Write (c+" ");
        a=b;
        b=c;
    }
}

Console.WriteLine("Переменная А ");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Переменная В ");
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Размер ");
int N=Convert.ToInt32(Console.ReadLine());

Febonacci(a,b,N);
Console.WriteLine("Размер ");


void Fibonachchi (int n, int a, int b)
{
    Console.Write($"{a} {b} ");
    int fib = a + b;
    int fib2 = b;
    int fib3 = 0;
    for (int i = 0; i <= n; i++)
    {
        Console.Write($"{fib} ");
        fib3 = fib + fib2;
        fib2 = fib;
        fib = fib3;
    }

}
Console.Write("Введи сколько цифр надо: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи первое число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Fibonachchi(n, a, b);





//3.Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//вход инт храним стринг

