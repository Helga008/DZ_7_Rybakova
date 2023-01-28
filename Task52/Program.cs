// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetUserData(string message)
{
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;

}

int[,] get2DoubleArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for(int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start,finish+1);
        }
    }
    return array;
}


void printInColor(string message)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(message);
    Console.ResetColor();
}

void PrintArray(int[,] array)
{
    Console.Write(" \t");
    for(int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
    Console.WriteLine();
    }
}

void Srednee(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i,j];
        }
        Console.Write($"{result / array.GetLength(1)}");
    }
}

int col = GetUserData("Введите количество столбцов: ");
int row = GetUserData("Введите количество строк: ");
int[,] arr = get2DoubleArray(col, row, 0, 10);
PrintArray(arr);
Srednee(arr);

