
/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
*/

int[,,] GetArray(int m, int n, int p, int min, int max)
{
    int[,,] result = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                int num = new Random().Next(min, max + 1);
                if (CheckRandom(result, m, n, p, num)) continue;
                {
                    result[i, j, k] = num;
                }

            }
        }
    }
    return result;
}

bool CheckRandom(int[,,] arr, int row, int col, int layer, int num)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < layer; k++)
            {
                if (arr[i, j, k] == num) return true;
            }
        }
    }
    return false;
}


void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите количество слоев массива: ");
int layers = int.Parse(Console.ReadLine());

int[,,] array = GetArray(rows, columns, layers, 10, 99);
PrintArray(array);
Console.WriteLine();
