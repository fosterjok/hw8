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

int a = 0;
int sum2 = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
    sum2 = sum2 + array[0, j];
}
for (int i = 0; i < array.GetLength(0); i++)
{int sum1 = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        sum1 = sum1 + array[i, j];
    if (sum1 < sum2)
    {
        sum2 = sum1;
        a = i;
    }
}

Console.WriteLine($"{a} {sum2}");
