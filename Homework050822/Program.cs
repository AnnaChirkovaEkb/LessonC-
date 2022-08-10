/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Input first number:  ");
int firstnum=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number:  ");
int secondnum=Convert.ToInt32(Console.ReadLine());

int max;
int min;

if (firstnum>secondnum)
{
    max=firstnum; 
    min=secondnum;
}
else
{
    min=firstnum;
    max=secondnum ;
}

Console.WriteLine($"More  number is {max}, smallest number is {min}");
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих

/*
 Console.WriteLine("Input first number:  ");
int firstnum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number:  ");
int secondnum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number:  ");
int thirdnum = Convert.ToInt32(Console.ReadLine());

int max;

    if (firstnum>secondnum && firstnum> thirdnum)
    {
        max=firstnum;
    }
    else if(secondnum> thirdnum && secondnum>firstnum)
    {
        max=secondnum;
    }
    else 
    {
        max=thirdnum;
    }


Console.WriteLine($"More  number is {max}.");
*/
   

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Input number:  ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2==0)
{
    Console.WriteLine($"Number {num} is even.");
}
else
{
    Console.WriteLine($"Number {num} is not even.");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number:  ");
int num = Convert.ToInt32(Console.ReadLine());

int even=2;

Console.Write ("All even number in line: ");
while(even<=num && even>=2)
{
    Console.Write(even + " ");
    even=even+2;
}
Console.WriteLine ();
