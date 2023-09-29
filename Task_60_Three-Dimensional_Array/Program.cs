void RandElement(int[, , ] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, k, j] = new Random().Next(1, 10);
            }
        }
    }
}

void PrintArr(int[, , ] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[i, j, k]} - ({i}, {j}, {k}) ");
            }
            System.Console.WriteLine();
        }
        
    }
}


int[, , ] arr = new int[2, 2, 2];
RandElement(arr);
PrintArr(arr);