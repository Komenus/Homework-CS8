// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
int columns = rows + 1;
int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
Console.WriteLine();
Console.Write($"Номер строки с наименьшей суммой значений {CountArray(array) +1} : ");
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
int CountArray(int[,] array)
{   
    int minsum = 0;
    int row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
    minsum = minsum + array[0, i];
    int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j]; 
        }
        if ( minsum > sum ) 
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}    
