// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(-9, 10) + new Random().Next(-1, 2) * new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте величину массива");
Console.Write("Строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцы: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);