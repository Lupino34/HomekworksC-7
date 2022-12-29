// Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
void findIndex(int[,] newArray, int element) // Функция поиска в массиве заданного числа;
{
    int k = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (newArray[i,j] == element) 
            {
                Console.WriteLine($"Число расположено на позиции: ({i+1};{j+1}); ");
                k++;
            }
        }
    }
    if ( k == 0)  Console.WriteLine("Такого числа в заданном массиве нет.");
}
Console.WriteLine("Количество строк: ");
int stroka = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int stolbec = int.Parse(Console.ReadLine());
Console.WriteLine("Min значение: ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Max значение: ");
int maxValue = int.Parse(Console.ReadLine());
int[,] Massive1 = GetArray(stroka, stolbec, minValue, maxValue); // Вызов функции, заполняющей массив;
PrintArray(Massive1); // Вывод массива на экран;
Console.WriteLine("Введите искомое значение: ");
int iskomElement = int.Parse(Console.ReadLine());
Console.WriteLine();
findIndex(Massive1, iskomElement); // Вывод результатов поиска;