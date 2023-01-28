// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int GetUserData(string message)
{
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;

}

double[,] get2DoubleArray(int colLength, int rowLength, int start, int finish)
{
    double[,] array = new double[colLength, rowLength];
    int divider = 100;
    for(int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start *divider ,finish+1 * divider) / (divider + 0.0);
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

void PrintArray(double[,] array)
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

int col = GetUserData("Введите количество столбцов: ");
int row = GetUserData("Введите количество строк: ");
double[,] arr = get2DoubleArray(col, row, -10, 10);
PrintArray(arr);
