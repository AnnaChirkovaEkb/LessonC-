/*// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Input number which have 3 figure:  ");
int num = Convert.ToInt32(Console.ReadLine());

int ed=num%10;
int sot=num/100;

int result=(num-sot*100-ed)/10;

Console.Write ($"The  second figure of number is: {result} ");
Console.WriteLine();

*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input any number:  ");
int num = Convert.ToInt32(Console.ReadLine());

int result;

while (num<0)
{
    num=num*(-1);
}
    if (num/1000<=1)
    {
        Console.Write ("The number have not third figure.");
        Console.WriteLine();
    } 
    else
    {
        while(num/1000>=1)
        {
            num=num/10;
        }    
        
        result=num%10;
                
        Console.Write($"The  third figure of number is: {result}");
        Console.WriteLine();
    }

*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input number which respond day of week:  ");
int num = Convert.ToInt32(Console.ReadLine());

if (num<=7)
{
    if (num>1 && num<=5)
    {
     Console.Write ("Is this day  weekend:NO.");
     Console.WriteLine();    
    }
    else
    {
    Console.Write ("Is this day  weekend:Yes.");
    Console.WriteLine();    
    }
}
else
{
Console.Write ("Error!!!");
Console.WriteLine();    
}







