
/*
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от M до N.

//M = 1; N = 5. -> ""1, 2, 3, 4, 5""

//M = 4; N = 8. -> ""4, 6, 7, 8""

void ShowNumber(int n,int m)
{
    if (m!=n)
    {
        if (n>m) 
        {
            ShowNumber(n-1,m);
            Console.WriteLine(n+" ");
        }
        else
        {
            ShowNumber(m-1,n);
            Console.WriteLine(m+" ");
        }
    }
    else
        Console.WriteLine(m+" ");
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

ShowNumber(a,b);

*/


/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNumber(int n,int m)
{
    if (m!=n)
    {
        if (m>n)
            return n+SumNumber(n+1,m);
        else 
            return m+SumNumber(n,m+1);
    }
    else
    
        return m;
    
}


Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());


int sum=SumNumber(a,b);
Console.WriteLine($"The summa of all number in this branch is {sum}.");

*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//n = 3, m = 2 -> A(m,n) = 29

int Akkerman(int n,int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());


int function=Akkerman(a,b);
Console.WriteLine($"Value of function is {function}.");
