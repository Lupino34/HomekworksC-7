// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int min, int max) // Функция для заполнения массива данными;
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
void PrintArray(int[,] array) // Функция вывода массива на экран;
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void arifmet(int[,] newArray)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            sum += newArray[i, j];
        }
        Console.Write($"{sum/newArray.GetLength(0)}; ");
    }
}
Console.WriteLine("Количество строк: ");
int stroka = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int stolbec = int.Parse(Console.ReadLine());
Console.WriteLine("Min значение: ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Max значение: ");
int maxValue = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] Massive1 = GetArray(stroka, stolbec, minValue, maxValue); // Вызов функции, заполняющей массив;
PrintArray(Massive1); // Вывод массива на экран;
Console.WriteLine();
arifmet(Massive1);