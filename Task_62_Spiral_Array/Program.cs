void SpiralElements(int[, ] arr)
{
    int value = 1;
    
    int row = 0; 
    int col = 0; 
    int direction = 0; // Направление движения (0 - вправо, 1 - вниз, 2 - влево, 3 - вверх)
    
    for (int i = 0; i < arr.Length; i++)
        {
            arr[row, col] = value; 
            value++; 

            
            if (direction == 0) // Вправо
            {
                if (col < arr.GetLength(0) - 1 && arr[row, col + 1] == 0)
                {
                    col++;
                }
                else
                {
                    direction = 1;
                    row++;
                }
            }
            else if (direction == 1) // Вниз
            {
                if (row < arr.GetLength(0) - 1 && arr[row + 1, col] == 0)
                {
                    row++;
                }
                else
                {
                    direction = 2; 
                    col--;
                }
            }
            else if (direction == 2) // Влево
            {
                if (col > 0 && arr[row, col - 1] == 0)
                {
                    col--;
                }
                else
                {
                    direction = 3; 
                    row--;
                }
            }
            else if (direction == 3) // Вверх
            {
                if (row > 0 && arr[row - 1, col] == 0)
                {
                    row--;
                }
                else
                {
                    direction = 0; 
                    col++;
                }
            }
        }
}

void PrintArr(int[, ] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
}

int n = 4;
int[, ] arr = new int[n, n];
SpiralElements(arr);
PrintArr(arr);