// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
 //или же указание, что такого элемента нет.

 Console.Clear();

Console.Write("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine("");
Console.Write("Введите число для элемета строки: ");
int numLine = int.Parse(Console.ReadLine()!);
Console.Write("Введите число для элемета столбца: ");
int numColumn = int.Parse(Console.ReadLine()!);
FindElement(array, numLine, numColumn);

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
            array[i, j] = generator.Next(-100, 100);
        }
    }
}

void FindElement(int[,] FindEl, int a, int b)
{
    int rows = FindEl.GetLength(0);
    int columns = FindEl.GetLength(1);
    int index = 0;
    if (a > 0 && b > 0 && a <= rows && b <= columns)
    {
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                index = FindEl[a - 1, b - 1];
            }
        }
        Console.WriteLine("Значение элемента равна: " + index);
    }
    else
    {
        Console.WriteLine($"{a} и {b}: таких элементов нет в массиве");
    }
}