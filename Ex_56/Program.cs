/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
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

void GetSum(int[,] arr, int r, int c)
{
    int minRowSum = int.MaxValue;
    int indexMinRow = 0;

    for (int i = 0; i < r; i++)
    {
        int sum = 0;
        for (int j = 0; j < c; j++)
            sum += arr[i, j];

        if (sum < minRowSum)
        {
            minRowSum = sum;
            indexMinRow = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов {indexMinRow + 1}");
    Console.Write("[ ");
    for (int j = 0; j < c; j++) Console.Write($"{arr[indexMinRow, j]} ");
        
    Console.Write("]");
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
Console.WriteLine();
GetSum(array, rows, columns);
