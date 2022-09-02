//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

/*
double[,] CreateRandomDouble2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] =Math.Round(new Random().NextDouble()+ new Random().Next(minValue, maxValue + 1),1);
            
    return newArray;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandomDouble2dArray(m, n, min, max);
Show2dArray(myArray);

*/




//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

int[,] CreateRandomDouble2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] =new Random().Next(minValue, maxValue + 1);
            
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}


void FindNumber(int[,] array, int IndexInRow, int IndexInColumn)
{
    if(IndexInRow >= 0 && IndexInRow<array.GetLength(0) && 
       IndexInColumn >= 0 && IndexInColumn<array.GetLength(1))

    Console.WriteLine($"This number, with coordinate {IndexInRow},{IndexInColumn} is {array[IndexInRow,IndexInColumn]}");
    else Console.WriteLine($"Error: this number, with coordinate {IndexInRow},{IndexInColumn} did not find.");
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input find number in row (row begin to 0): ");
int NumberInRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input find number in column (colum begin to 0): ");
int NumberInColum = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandomDouble2dArray(m, n, min, max);
Show2dArray(myArray);


FindNumber(myArray, NumberInRow, NumberInColum);



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
double[] AverageSumColums(int[,] array)
{
    double[] avg=new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum=0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum=sum+array[i,j];
        }
        avg[j]=sum/array.GetLength(0);
    }
return avg;

}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine("The averages sum of column is:");
double [] a=AverageSumColums(myArray);
ShowArray(a);
Console.WriteLine();
*/