// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите индекс строки: ");
int rowsNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Номер индекс столбца: ");
int columnsNum = int.Parse(Console.ReadLine()!);
Console.WriteLine();


 if((rowsNum < array.GetLength(0)) && columnsNum < array.GetLength(1))
            {
                rows = rowsNum;
                columns = columnsNum;
                Console.WriteLine($"На позиции ({rowsNum},{columnsNum}) находится число {array[rows,columns]}");
            }
            else{
                Console.WriteLine("Такого элемента нет!");
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