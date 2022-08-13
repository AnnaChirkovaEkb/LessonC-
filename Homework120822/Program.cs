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
