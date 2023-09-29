int RandArr()
{
    int rand = new Random().Next(3, 5);
    return rand;
}

void RandElement(int[, ] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArr(int[, ] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void Sorting(int[, ] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        for (int k = j + 1; k < arr.GetLength(1); k++)
        {
            if (arr[i, j] < arr[i, k])
            {
                int temp = arr[i, j];
                arr[i, j] = arr[i, k];
                arr[i, k] = temp;
            }
        }
    }
}
}



int[, ] arr = new int[RandArr(), RandArr()];
RandElement(arr);
PrintArr(arr);
Sorting(arr);
System.Console.WriteLine();
PrintArr(arr);