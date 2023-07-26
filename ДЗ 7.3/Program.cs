// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] CalcAvg(int[,] arr)
{
    int rowsCount = arr.GetLength(0);
    int colsCount = arr.GetLength(1);

    double[] avg = new double[colsCount];

    for (int i = 0; i < rowsCount; i++) {
        for (int j = 0; j < colsCount; j++) {
            avg[j] += arr[i, j];
        }
    }

    for (int k = 0; k < avg.Length; k++) {
        avg[k] /= rowsCount;
    } 

    return avg;
}

void PrintAvg(double[] arr)
{
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Задайте величину массива");
Console.Write("Строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

double[] avg = CalcAvg(array);

Console.WriteLine("Среднее:");
PrintAvg(avg);