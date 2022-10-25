int [,,] array = new int[2,2,2];
int []nums= new int [90];
for (int i = 0; i < nums.GetLength(0); i++)
     nums[i]= i+10;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            while (array [i,j,k]==0)
            {int temp= new Random().Next(nums.GetLength(0));
            array[i,j,k]= nums[temp];
            nums[temp]=0;
                
            }
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
           Console.Write($"{array[i,j,k]} ");
        }
        Console.WriteLine();
    }
}