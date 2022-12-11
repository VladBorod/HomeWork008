// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();

int[,] array1 = GetArray1(3, 2, 1, 10);
PrintArray(array1);

Console.WriteLine("========");

int[,] array2 = GetArray2(2, 3, 1, 10);
PrintArray(array2);

Console.WriteLine("========");
Console.WriteLine(@CheckMatrix(array1, array2) ? "Произведение двух матриц: "
: "Условия не соблюдаются, умножение невозможно");

int[,] arrayMultiplication = MatrixMultiplication(array1, array2);
PrintArray(arrayMultiplication);

int[,] GetArray1(int m, int n, int minValue, int maxValue)
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

int[,] GetArray2(int m, int n, int minValue, int maxValue)
{
    int[,] inArray2 = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < inArray2.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            inArray2[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return inArray2;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

bool CheckMatrix(int[,] array1, int[,] array2)
{
    return (array1.GetLength(1) == array2.GetLength(0));
}

int[,] MatrixMultiplication(int[,] array, int[,] array2)
{
    int[,] matrixMultiply = new int[array.GetLength(0), array2.GetLength(1)];
    if (CheckMatrix(array, array2) == true)
    {
        for (int i = 0; i < matrixMultiply.GetLength(0); i++)
        {
            for (int j = 0; j < matrixMultiply.GetLength(1); j++)
            {
                matrixMultiply[i, j] = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    matrixMultiply[i, j] += array[i, k] * array2[k, j];
                }
            }
        }

    }
    return matrixMultiply;
}

