
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
int[,] ArrayDecreasing(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int k = 0; k < array.GetLength(1); k++)
            for(int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] < array[i, j + 1])
                        {              
                            int temp = array[i, j];
                            array[i, j] = array[i, j + 1];
                            array[i, j + 1] = temp;
                        }
                }
    return array;
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
Console.WriteLine();


ArrayDecreasing(myArray);
Show2dArray(ArrayDecreasing(myArray));

Console.WriteLine();

*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:1строка

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


void RowSumMin(int[,] array)
{
    
    int index=0;
    int minsumrow = 0;
   
    for(int i = 1; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for(int j = 0; j < array.GetLength(1); j++)
                {

                    sum = sum + array[i, j];
                }
            //Console.WriteLine($"Сумма минимум {i + 1} строки = {sum}");
            if(i ==0) 
            {
                minsumrow=sum;
            }
            else if (sum<minsumrow);
            {
                minsumrow=sum;
                index=i;
            }
    string line = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        line += array[index, j] + " ";
    }
    Console.WriteLine($"Minimum sum elemens in one row is {line}. ");                      

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

int[,] myArray = CreateRandom2dArray(m, n, min, max);

Show2dArray(myArray);
Console.WriteLine();

RowSumMin(myArray);

*/





//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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


int[,] Matrix(int[,] a, int[,] b)
{
    int[,] m = new int[a.GetLength(0), b.GetLength(1)];
    if (a.GetLength(1) != b.GetLength(0)) 
        {
            Console.WriteLine("These matrices cannot be multiplied");
            return m;
        }
    else
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {    
                    m[i, j] += a[i, k] * b[k, j];                
                }
            }
        }
        return m;
    }
    
}



Console.Write("Input number of rows in first matrix: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of rows in second matrix: ");
int m2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns in first matrix: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns in second matrix: ");
int n2 = Convert.ToInt32(Console.ReadLine());


Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = CreateRandom2dArray(m1, n1, min, max);  //
int[,] myArray2 = CreateRandom2dArray(m2, n2, min, max);  //

Show2dArray(myArray1);
Console.WriteLine();

Show2dArray(myArray2);
Console.WriteLine();


int [,] creatArray=Matrix(myArray1,myArray2);

Show2dArray(creatArray);

*/


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] CreateRandom3dArray(int x, int y, int z, int minValue, int maxValue)
{   
     if((x * y * z) > (maxValue- minValue)) 
        {
            //Console.WriteLine("Error: don't  have element!");
            Console.WriteLine($"{x * y * z} > {maxValue- minValue}");
            int[,,] array = new int[0, 0, 0];
            return array;
        }
    else
        {             
            int[,,] array = new int[x, y, z];
            for(int i = 0; i < x; i++)
                for(int j = 0; j < y; j++)
                    for(int k = 0; k < z; k++)
                        {
                            int n = array[i, j, k];
                            
                            for(int count = 0; count < x * y * z; count++)
                                {
                                    for(int a = 0; a < x; a++)
                                        for(int b = 0; b < y; b++)
                                            for(int c = 0; c < z; c++)
                                                {
                                                    if(n == array[a, b, c])
                                                        {
                                                            n = new Random().Next(minValue, maxValue + 1);
                                                            a = 0;
                                                            b = 0;
                                                            c = 0;
                                                            count = 0;
                                                        }

                                                      
                                                }
                                }                
                            array[i, j, k] = n;
                        }
            return array;
    }

}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }   
}

Console.Write("Input number of first parametre: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of second parametre: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of third parametre: ");
int o = Convert.ToInt32(Console.ReadLine());


Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(m, n, o, min, max);

Show3dArray(myArray);
Console.WriteLine();





//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] arrayNew = new int[rows, columns];
    int number=01;
    
        for(int k = 0; k < rows / 2; k++)
        {
            int i = k;
            int j = k;
            for(j = k; j < columns - k; j++)
                {
                    if(number <= rows * columns)
                        {
                            arrayNew[i, j] = number;
                            number++;
                        }
                    else return arrayNew;
                }
            j = columns - k - 1;
            for(i = k + 1; i < rows - k; i++)
                {
                    if(number <= rows * columns)
                        {
                            arrayNew[i, j] = number;
                            number++;
                        }
                    else return arrayNew;
                }
            i = rows - k - 1;
            for (j = columns - k - 2; j >= k; j--)
                {
                    if(number <= rows * columns)
                        {
                            arrayNew[i, j] = number;
                            number++;
                        }
                    else return arrayNew;
                }  
            j = k;
            for(i = rows - k - 2; i > k; i--)
                {
                    if(number <= rows * columns)
                        {
                            arrayNew[i, j] = number;
                            number++;
                        }
                    else return arrayNew;
                }    


        }
    return arrayNew;
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

int[,] myArray = CreateRandom2dArray(4, 4, 01, 16);

Show2dArray(myArray);
Console.WriteLine();

*/







