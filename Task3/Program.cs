// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
Console.Write("Введите количество строк  массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());;
int[,] array = GetArray(rows, columns, 1, 10);
int[,] array1 = GetArray(rows, columns, 1, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
multArray(array, array1);
PrintArray(multArray(array, array1));
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);

        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        { Console.Write($"{inArray[i, j]} "); }
        Console.WriteLine();
    }
}
int [,] multArray (int [,] array, int [,] array1) 
{
    int [,] array2 = new int [array.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k <array.GetLength(1); k++)
            {
                array2 [i,j] +=  array [i,k] * array1 [k,j];
            }

        }
    }
    return array2;
}