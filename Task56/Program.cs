// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random random = new Random();
int rows = random.Next(4, 7);
int columns = random.Next(4, 7);
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);

int indexMin = 0;
int sumMin = RowSum(array, indexMin);
Console.WriteLine();
Console.WriteLine($"The {indexMin + 1} row with the sum of elements = {sumMin}");

for (int i = 1; i < rows; i++)
{
    int sum = RowSum(array, i);
    Console.WriteLine($"The {i + 1} row with the sum of elements = {sum}");
    if (sum < sumMin)
    {
        sumMin = sum;
        indexMin = i;
    }
}
Console.WriteLine();
Console.WriteLine($"The {indexMin + 1} row with the smallest sum of elements = {sumMin}");

void FillArray(int[,] array, int startnumber = 0, int finishnumber = 10)
{
    finishnumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startnumber, finishnumber);
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

int RowSum(int[,] array, int i)
{
    int columns = array.GetLength(1);
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += array[i, j];
    }
    return sum;
}
