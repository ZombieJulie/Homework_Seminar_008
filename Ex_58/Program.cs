
/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
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


int[,] GetProduct(int[,] arrA, int[,] arrB, int r, int c)
{
    int[,] arrC = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            for (int k = 0; k < c - 1; k++)
            {
                arrC[i, j] = arrA[i, j] * arrB[i, j];
            }
        }
    }
    return arrC;
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrayA = GetArray(rows, columns, 0, 10);
int[,] arrayB = GetArray(rows, columns, 0, 10);
int[,] arrayC = GetProduct(arrayA, arrayB, rows, columns);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(arrayC);

