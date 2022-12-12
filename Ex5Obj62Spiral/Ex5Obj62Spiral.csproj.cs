// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] arrayNew = new int [6, 9];
int[,] newSpiral = Spiral(arrayNew);
PrintArray(newSpiral);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" [ {inArray[i, j],3} ] ");
        }
        Console.WriteLine();
    }
}

int[,] Spiral (int[,] inArray)
{
    int[,] spiralArray = new int[inArray.GetLength(0), inArray.GetLength(1)];
    int random = 1;
    int altitudeArray = spiralArray.GetLength(0);
    int breadthArray = spiralArray.GetLength(1);
    for (int turn = 0; turn < altitudeArray; turn++)
    {
        for (int i = turn; i < altitudeArray - turn; i++)
        {
            for (int j = turn; j < breadthArray - turn; j++)
            {
                if (i == turn && j == turn)
                {
                    for (j = turn; j < breadthArray - turn; j++)
                                        
                        spiralArray[i, j] = random++;
                    
                }
                else if (i == (altitudeArray + (turn + 1)) - altitudeArray & j == breadthArray - (turn + 1))
                {
                    for (i = (turn + 1); i < altitudeArray - (turn + 1); i++)
                    
                        spiralArray[i, j] = random++;
                    
                }
            }
        }
        for (int i = altitudeArray - (turn + 1); i > (turn - 1); i--)
        {
            for (int j = breadthArray - (turn + 1); j > (turn - 1); j--)
            {
                if (i == altitudeArray - (turn + 1) && j == breadthArray - (turn + 1))
                {
                    for (j = breadthArray - (turn + 1); j > turn; j--)
                                        
                        spiralArray[i, j] = random++;
                    
                }
                else if (j == turn & i < altitudeArray - (turn + 1))
                {
                    for (i = altitudeArray - (turn + 1); i > turn; i--)
                    
                        spiralArray[i, j] = random++;
                    
                }
            }
        }
    }
    return spiralArray;
}