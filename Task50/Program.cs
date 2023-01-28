// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void Proverka(int[,] array, int numbcol, int numbrow)
{
    if (numbcol < array.GetLength(0) && numbrow < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента равно {array[numbcol,numbrow]}");
    }
    else
    {
        Console.WriteLine("Данного элемента нет в массиве");
    }
}
   

int col = GetUserData("Введите количество столбцов: ");
int row = GetUserData("Введите количество строк: ");
int[,] arr = get2DoubleArray(col, row, -10, 10);
PrintArray(arr);
int vvodcol = GetUserData("Введите номер столбца");
int vvodrow = GetUserData("Введите номер строки");
Proverka(arr, vvodcol, vvodrow);
