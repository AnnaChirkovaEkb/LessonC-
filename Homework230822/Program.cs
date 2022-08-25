
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3


int [] CreatRandomArray(int size)
{
    int [] newArray=new int[size];
    for (int i=0; i<size; i++)
    
    {
        Console.WriteLine($"Input {i} number: ");
        newArray [i]=Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i=0;i<array.Length;i ++)
    Console.Write(array [i]+ " ");

    Console.WriteLine();
}

int CountNumberMoreZero(int [] array)
{
    int current=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0) current=current+1;
        //else current++;
    }
    Console.WriteLine($"Qantity number which  more zero is {current} .");
    return current;
}

Console.WriteLine("Input size for array: ");
int a=Convert.ToInt32(Console.ReadLine());


int [] myArray=CreatRandomArray(a);
ShowArray (myArray);
CountNumberMoreZero(myArray);

/*

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double PointOfIntersectionLines (double b1,double k1,double b2,double k2)
{
double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;

Console.WriteLine($"Coordinates of point is:x={x} and y={y}");

return x;
return y;
}

Console.Write("Input for first linie: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input for first linie: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input for second linie: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input for second linie: ");
double k2 = Convert.ToInt32(Console.ReadLine());


PointOfIntersectionLines (b1,k1,b2,k2);

*/