/*
Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
каждой строки массива.
Например, 
1 4 7 2
5 9 2 3
8 4 2 4

7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] Get2DIntArray(int rowLength, int colLength, int start, int end)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void PrintInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}

void Print2DArray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        PrintInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("------------------------------------------- \n");
}

int [,] SortMaxToMinInRow (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = j + 1; k < array.GetLength(1); k++)
                {
                    if (array[i,j] < array[i,k])
                    {
                        int temp = array[i,j];
                        array[i,j] = array[i,k];
                        array[i,k] = temp;
                    }                   
                }            
            }
    }
    return array;
}
    




int [,]arr = Get2DIntArray (3,5,0,10);
Print2DArray(arr);
arr = SortMaxToMinInRow (arr);
Print2DArray(arr);


