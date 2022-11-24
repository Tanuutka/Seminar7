// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число стобцов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
AverageColumn(array);

void PrintArray(int[,] Printarray)
{
    int rows = Printarray.GetLength(0);
    int columns = Printarray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{Printarray[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = generator.Next(-10, 100);
        }
    }
}

void AverageColumn(int[,] FindEl)
{
    int rows = FindEl.GetLength(0);
    int columns = FindEl.GetLength(1);
    double averSum = 0;
    for (int j = 0; j < columns; j++)
    {
        double Sum = 0;
        for (int i = 0; i < rows; i++)
        {
            Sum += FindEl[i, j];
        }
        Console.Write("");
        averSum = Math.Round(Sum / rows, 1);
        Console.WriteLine($"Среднее арифметическое столбца №{j + 1}  = {averSum}");
    }
}
