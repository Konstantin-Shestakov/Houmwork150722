/*// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();

double [,] GetArray(int m, int n)
{
    double [,] result = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = (new Random().NextDouble())*10;
        }
    }
    return result;
}

void PrintArray(double [,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"\t {inArray[row, column]:f1} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
*/
/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

Console.Clear();

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
     int[,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int [,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"\t {inArray[row, column]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите строку искомого элемента: ");
int pozs = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец искомого элемента: ");
int pozc = Convert.ToInt32(Console.ReadLine());

void changedArray(int [,] inArray)
{
    if (inArray.GetLength(0) < pozs || inArray.GetLength(1) < pozc)
    {
        Console.WriteLine($"[{pozs},{pozc}] -> такого числа нет");
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
        if( i == pozs && j == pozc)
        {
        Console.WriteLine($"({i},{j}) -> {inArray[i,j]}");
        } 

        }

        Console.WriteLine();
    }
}    

int [,] array = GetArray(rows, columns,0,9);
PrintArray(array);
Console.WriteLine();
changedArray(array);
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

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
            for (int row = 0; row < inArray.GetLength(0); row++)
            {
                for (int column = 0; column < inArray.GetLength(1); column++)
                {
                    Console.Write($"\t {inArray[row, column]} ");
                }
                Console.WriteLine();
            }
        }
        Console.Write("Введите количество строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        void changedArray(int[,] inArray)
        {
            double sum = 0;
            int Count = 0;
            
            for (int j = 0; j < inArray.GetLength(1); j++)
            
            {
                 
                                    
               
                 for (int i=0; i < inArray.GetLength(0); i++)
                 {
                  sum = sum + inArray[i,j];
                        Count =Count+1;
                                          
                 }
                Console.Write($"\t {sum/Count}"); 
                sum = 0; Count = 0;
            }
            
             Console.WriteLine();
           
            
            
            
        }


        int[,] array = GetArray(rows, columns, 1, 9);
        PrintArray(array);
        Console.WriteLine();
        changedArray(array);
    }
}