/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void printArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine ();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write ($"{array [i,j,k]} ({i},{j},{k}); ");
            }
        }
        
    }
    Console.WriteLine ();
}

int[,,] array3D = new int[,,] { { { 15, 28 }, { 41, 54 } }, { { 85, 91 }, { 64, 32 } } };
printArray (array3D);
