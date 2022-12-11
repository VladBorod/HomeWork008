// Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[] array = UniqueStringArrayCreation(2, 2, 2, 1, 99);
Console.WriteLine();

UniqueStringArrayPrint(array);
Console.WriteLine();

(int[,,] volumetricArray, int i, int j, int k) = ArrayConvertionStringTo3D(array, 2, 2, 2);
Console.WriteLine();

PrintArray(volumetricArray, i, j, k);
Console.WriteLine();

// Создание уникальной последовательности--------------------------------------------------

int[] UniqueStringArrayCreation(int rows, int columns, int dept, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] array = new int[rows * columns * dept];
    for (int i = 0; i < rows * columns * dept; i++)
    {
        bool elementsUnique;
        do
        {
            array[i] = rnd.Next(minValue, maxValue);
            elementsUnique = true;
            for (int j = 0; j < i; j++)
                if (array[i] == array[j])
                {
                    elementsUnique = false;
                    break;
                }
        } while (!elementsUnique);
    }
    return array;
}

// Вывод уникальной одномерной последовательности--------------------------------------------------------

void UniqueStringArrayPrint(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($" [{inArray[i]}]  ");
    }
}

// Конвертация одномерной в двумерную последовательность-------------------------------------------------

(int[,,], int, int, int) ArrayConvertionStringTo3D(int[] inArray, int row, int columns, int profound)
{
    int[,,] threeDArray = new int[row, columns, profound];
    int indexX = 0;
    int indexY = 0;
    int indexZ = 0;
    int m = 0;
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                threeDArray[i, j, k] = array[m];
                indexX = i;
                indexY = j;
                indexZ = k;
                m++;
            }
        }
    }
    return (threeDArray, indexX, indexY, indexZ);
}

// Вывод 3Д последовательности и индексов эжлементов в консоль--------------------------------------------

void PrintArray(int[,,] volumetricArray, int indexI, int indexJ, int indexK)
{
    for (int i = 0; i < volumetricArray.GetLength(0); i++)
    {
        for (int j = 0; j < volumetricArray.GetLength(1); j++)
        {
            for (int k = 0; k < volumetricArray.GetLength(2); k++)
            {
                if (i == 0 && j == 1 && k == 1)
                Console.WriteLine($"[{volumetricArray[i, j, k]} ({i}, {j}, {k}) ]");
                else 
                Console.Write($"[{volumetricArray[i, j, k]} ({i}, {j}, {k}) ]");
            }
        }
    }
}