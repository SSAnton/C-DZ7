// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int[,] array = new int[3, 4];

FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Введите позицию искомого элемента");
Console.Write("Строка: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i > 0 && i <= array.GetLength(0) && j > 0 && j <= array.GetLength(1)) {
    Console.WriteLine("Ваш элемент = " + array[i - 1, j - 1]);
} else {
    Console.WriteLine("Такого элемента нет");
}