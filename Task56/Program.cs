/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int FindSumInRow (int [,] array, int row)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array [row, i];
    }
    return sum;    
}

int FindMinValue (int [] array)
{
    int numberOfRow = 0;
    int min = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            numberOfRow = i;
        }
        
    }
    return numberOfRow; 
}

int [,] array = Get2DIntArray (3,4,0,10);
Print2DArray (array);

int [] sumRows = new int [array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
    sumRows [i] = FindSumInRow (array, i);
}
int numRow = FindMinValue (sumRows);
Console.WriteLine ($"Наименьшая сумма элементов в {numRow} строке");