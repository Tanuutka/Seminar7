// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число стобцов массива: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);

void FillArray(double[,] array)
{
    Random generator = new Random();
    double minValue = -100;
    double mixValue = 100;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(generator.NextDouble() * (mixValue - minValue) + minValue, 1);
        }
    }
}

void PrintArray(double[,] Printarray)
{
    for (int i = 0; i < Printarray.GetLength(0); i++)
    {
        for (int j = 0; j < Printarray.GetLength(1); j++)
        {
            Console.Write($"{Printarray[i, j]} ");

        }
        Console.WriteLine();
    }
}
