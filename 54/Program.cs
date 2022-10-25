/* Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/


int[,] array = new int[4, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();

}

for (int i = 0; i < array.GetLength(0); i++)

{
    for (int k = 0; k < array.GetLength(1) - 1; k++)
    {

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {

            if (array[i, j] < array[i, j + 1])
            {
                int temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }

        }
    }
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)

{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();

}