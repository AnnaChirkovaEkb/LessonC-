/*

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//размер от 100до 1000, %2 =0, счетчик каррент++

int [] CreatRandomArray(int size)
{
    int [] newArray=new int[size];
    for (int i=0; i<size; i++)
    
    {
        Console.WriteLine($"Input {i} number which have tree elements: ");
        newArray [i]=Convert.ToInt32(Console.ReadLine());

             
        if (newArray [i]<100 || newArray [i]>1000)
        Console.WriteLine($"This number {newArray [i]}  have not tree elements! ");
        else Console.WriteLine("OK");
    }
    return newArray;

}

void ShowArray (int [] array)
{
    for (int i=0;i<array.Length;i ++)
    Console.Write(array [i]+ " ");

    Console.WriteLine();
}

void CountEvenNumber(int [] array)
{
int count=0;

 for (int i=0;i<array.Length;i ++)
    {
    if (array [i]%2==0) count=count+1;
    else i++;
    }


Console.WriteLine($"Even number in massive is: {count}   .");
}

Console.WriteLine("Input size for array: ");
int a=Convert.ToInt32(Console.ReadLine());


int [] myArray=CreatRandomArray(a);
ShowArray (myArray);
CountEvenNumber(myArray);

*/

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//размер,индекс % больше 0,сумма

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

int CountSumNotEvenIndex(int [] array)
{
int Sum=0;
 for (int i=1;i<array.Length;i ++)
    {
    if ((i-1)%2==0) 
    {
    Sum=array[i]+Sum;
    //Console.WriteLine($" need {i} , {Sum} ");
    i=i+1;
    }
    
    else i=i+1;
      
    }

Console.WriteLine($"Sum of number which have not even index: {Sum}   .");
return Sum;


}

Console.WriteLine("Input size for array: ");
int a=Convert.ToInt32(Console.ReadLine());


int [] myArray=CreatRandomArray(a);
ShowArray (myArray);
CountSumNotEvenIndex(myArray);

*/




//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//что такое вещественные,найти максимальный и минимальный


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

int FindBetwenMaxMin(int [] array)
{
    int maxnumber=array[0];
    int minnumber=array[0];
    int result=0;
       for (int i=0; i<array.Length; i++)
    {
        if(array[i]<=minnumber) minnumber=array[i];     
        if(array[i]>=maxnumber) maxnumber=array[i];
        
    result=maxnumber-minnumber;
    }

Console.WriteLine($"The max number is {maxnumber}, min is {minnumber}"); 
Console.WriteLine($"The result is {result}");      
return maxnumber;
return minnumber;
return result;
}
    

Console.WriteLine("Input size for array: ");
int a=Convert.ToInt32(Console.ReadLine());


int [] myArray=CreatRandomArray(a);
ShowArray (myArray);
FindBetwenMaxMin(myArray);

