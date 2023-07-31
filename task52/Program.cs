// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк массива");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int columns = int.Parse(Console.ReadLine());

int[,] Massive = new int[rows, columns];
FillArray2D(Massive);
PrintArray2D(Massive);

double[] avgMassive = new double[Massive.GetLength(1)];

for (int i = 0; i < Massive.GetLength(1); i++)
{
    double count = 0.0;
    for (int j = 0; j < Massive.GetLength(0); j++)
    {
        count += Massive[j, i];
    }
    avgMassive[i] = count / Massive.GetLength(0);
}
PrintArray(avgMassive);


void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Среднее значение по столбцу " +(i+1) +": - "  +array[i]);
    }
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

