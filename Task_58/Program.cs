// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество сстолбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrayA = new int[m, n];
int[,] arrayB = new int[m, n];
int[,] arraysProduct = new int[m, n];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j], 4}");
        }
        Console.WriteLine();
    }
}

void ProductOfArrreys(int[,] array1, int[,] array2)
{
    if(array1.GetLength(0) < array2.GetLength(1))
    {
        Console.WriteLine("Невозможно получить произведение массивов :(");
        return;
    }
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            arraysProduct[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                arraysProduct[i, j] += array1[i, k] * array2[k, j];
                
            }
            Console.Write($"{arraysProduct[i, j], 4}");
        }
        Console.WriteLine();
    }
    
}


PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
ProductOfArrreys(arrayA, arrayB);
