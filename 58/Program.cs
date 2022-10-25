int [,] array = new int [2,2]
{
    {2, 4},
    {3 , 2 }
};
int [,] array2 = new int [2,2]
{
    {3,4},
    {3,3}
};

int [,] array3= new int [2,2];
for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            array3[i,j] += array[i,k]* array2[k,j];
        }
    }
}

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        Console.Write($"{array3[i,j]} ");
    }
    Console.WriteLine();
}