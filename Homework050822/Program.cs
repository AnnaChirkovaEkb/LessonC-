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
   



