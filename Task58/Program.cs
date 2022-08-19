// Задача 58. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

int n = 4;
int[,] array = new int[n, n];
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int index = 1;
    int i = 0;
    int j = 0;

    while (index <= rows * columns)
    {
        array[i, j] = index;
        index++;
        if (i <= j + 1 && i + j < columns - 1)
        {
            j++;
        }
        else if (i < j && i + j >= rows - 1)
        {
            i++;
        }
        else if (i >= j && i + j > columns - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}