/* Задача 62. Заполните спирально массив 4 на 4. */

void GetSpiral(int[,] array)
{
    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = number;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
        number++;
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер матрицы: ");
int size = int.Parse(Console.ReadLine());

int[,] spiral = new int[size, size];
GetSpiral(spiral);
PrintArray(spiral);
