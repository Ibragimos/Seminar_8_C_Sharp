Console.Clear();
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

void MinElementsRow(int[, ] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    int minRowSum = 0;
    int minRowIndex = 0;

    for (int j = 0; j < columns; j++)
    {
        minRowSum += arr[0, j];
    }

    for (int i = 0; i < rows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < columns; j++)
        {
            rowSum += arr[i, j];
        }
        
        Console.WriteLine($"Сумма элементов в строке {i+1}: {rowSum}");
       
        if (minRowSum > rowSum)
        {
            minRowSum = rowSum;
            minRowIndex = i;
        }
    }

    Console.WriteLine($"Минимальная сумма элементов в строке {minRowIndex + 1}: {minRowSum}");
}




int[, ] arr = new int[4, 3];
RandElement(arr);
PrintArr(arr);
System.Console.WriteLine();
MinElementsRow(arr);