// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();

int[,] array = GetArray(4, 4, 1, 99);
PrintArray(array);
int[,] sortedByDescending = SortDescending(array);

Console.WriteLine();

SortDescending(array);
PrintArray(sortedByDescending);

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
            Console.Write($" {inArray[i, j],3}  ");
        }
        Console.WriteLine();
    }
}

int[,] SortDescending(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - 1; k++)
            {
                if (inArray[i, k] < inArray[i, k + 1])
                {
                    int temp = inArray[i, k + 1];
                    inArray[i, k + 1] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }
        }
    }
    return inArray;
}