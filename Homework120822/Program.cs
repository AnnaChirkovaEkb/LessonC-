/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.(зеркальное)

int Palindrom (int n)
{
    int tenthous=n/10000;
    //Console.WriteLine(tenthous);
    int thous=(n/1000)%10;
    //Console.WriteLine(thous);
    int doz=(n%100)/10;
    //Console.WriteLine(doz);
    int ed=n%10;
    //Console.WriteLine(ed);  
    
    if(n<10000 && n>99999)
        Console.WriteLine("Error!");
    else if(tenthous==ed && thous==doz)
        
        Console.WriteLine("Yes, it is a palindrom.");

    else
       Console.WriteLine("No, it is not a palindrom."); 

return n;
}

Console.WriteLine("Input any whole number whitch have 5 figures:  ");
int number=Convert.ToInt32(Console.ReadLine());

Palindrom(number);
*/
//Задача 21:Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistant(double  x1,double  y1,double  z1,double  x2,double  y2,double  z2)
{
    
}

/*
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void ShowCube (int n)
{
    Console.WriteLine($"Cubes of number {n} is: ");
    int current=1;
    while(current<=n)
    {
        int Cube=current*current*current;
        Console.Write($"{Cube},");
        current++;
    }

}

Console.WriteLine("Input any whole number:  ");
int number=Convert.ToInt32(Console.ReadLine());

ShowCube(number);

Console.WriteLine();

*/


