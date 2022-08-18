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

int[,] GetProduct(int[,] arrA, int[,] arrB)
{
    int[,] arrC = new int[arrA.GetLength(0), arrB.GetLength(1)];
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrB.GetLength(1); j++)
                {
                    for (int k = 0; k < arrA.GetLength(1); k++)
                    {
                        arrC[i, j] += arrA[i, k] * arrB[k, j];
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
int[,] arrayC = GetProduct(arrayA, arrayB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(arrayC);