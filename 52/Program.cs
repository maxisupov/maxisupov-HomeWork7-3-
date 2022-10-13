// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Выберите столбец, для нахождения среднего арифметического: ");
int ArMeanCol = int.Parse(Console.ReadLine()!);

double ArMean = GetSumColumns(array);
double ResArMean = ArMean / rows;
Console.WriteLine($"Cреднее арифметическое элементов столбца {ArMeanCol} = {Math.Round(ResArMean, 3)}");

int GetSumColumns(int[,] array)
{   
    int SumCol = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j == ArMeanCol - 1)
            {
                SumCol = SumCol + array[i,j];
            }            
        }
    }
    return SumCol;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}