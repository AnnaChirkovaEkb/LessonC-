/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.



double ShowRaicing (int A,int B)
{
        
    double current;

    current=Math.Pow(A,B);
    Console.WriteLine($"Degrees {B} of number {A} is: {current} .");

    return current;
}

Console.WriteLine("Input any whole number:  ");
int number=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input naturale degrees:  ");
int degrees=Convert.ToInt32(Console.ReadLine());

ShowRaicing(number,degrees);

Console.WriteLine();

*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSumNum(int n)
{
    int Sum=0;
    while(n>1)
    {
        int current=n%10;
        Sum=Sum+current;
        //Console.WriteLine($"test {n} , {current} = {Sum}");
        n=n/10-1;
        n++;
    }

 Console.WriteLine($"Sum all figura of  number is {Sum}.");
 
 return n;
}

Console.WriteLine("Input any number:  ");
int number=Convert.ToInt32(Console.ReadLine());

FindSumNum(number);

*/


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray(int size)
{
int [] newArray=new int[size];
for (int i=0;i<size;i++)
{
    Console.Write($"Input {i} element  of the array:  ");
    newArray[i]=Convert.ToInt32(Console.ReadLine());
}
return newArray;
}

void ShowArray(int[] array)
{
    for (int i=0;i<array.Length;i++)
    Console.Write(array[i]+ " ");

    Console.WriteLine();
}

Console.Write("Input size  of the array:  ");
    int n=Convert.ToInt32(Console.ReadLine());

int [] myArray=CreateArray(n);
ShowArray(myArray);



