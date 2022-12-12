// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] array = GetArray(3, 4, 1, 10);
PrintArray(array);

Console.WriteLine();

int[] minimalSumOfElementsRow = MinimalSumOfElementsRow(array);
MinimalSumOfElementsRow(array);
PrintSmallestResult(minimalSumOfElementsRow);

int minimalRowSummary = PrintSmallestResult(minimalSumOfElementsRow);
Console.WriteLine($"Минимальная сумма, строка ----> {minimalRowSummary + 1}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] inArray = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return inArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] MinimalSumOfElementsRow(int[,] inArray)
{
    int[] summaryResult = new int[inArray.GetLength(0)]; //Stone!
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            summaryResult[i] += inArray[i, j];
        }
    }
    return summaryResult;
}

int PrintSmallestResult(int[] array)
{
    int resultSumm = array[0];
    int resultRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultSumm)
        {
            resultSumm = array[i];
            resultRow = i;
        }
    }
    return resultRow;
}
