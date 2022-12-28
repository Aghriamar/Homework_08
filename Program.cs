//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
//строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
/*
void Swap(int[,] array, int a, int b, int i, int k)
{
    int c = a;
    array[i,k - 1] = a = b;
    array[i,k] = b = c;
}

int[,] MaxMinSortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                int a = array[i,k];
                int b = array[i,k + 1];
                if (array[i, k] < array[i, k + 1])
                {
                    Swap(array, array[i, k], array[i, k + 1], i, k + 1);
                }
            }
        }
    }    
    return array;
}

int[,] array = CreateRandom2DArrayInt();
Show2dArrayInt(array);
Console.WriteLine("");
Console.WriteLine("Sorting from largest to smallest:");
Show2dArrayInt(MaxMinSortArray(array));

int[,] CreateRandom2DArrayInt()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void Show2dArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write($"[ {array[i, j]} ");
            else if (j == array.GetLength(1) - 1)
                Console.WriteLine($"{array[i, j]} ]");
            else
                Console.Write($"{array[i, j]} ");
        }
    }
}
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
//с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int SumElementsLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
int[,] array = CreateRandom2DArrayInt();
Show2dArrayInt(array);
int minLine = 0;
int sumLine = SumElementsLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SumElementsLine(array, i);
    if (sumLine > temp)
    {
        sumLine = temp;
        minLine = i;
    }
}
Console.WriteLine("");
Console.WriteLine($"{minLine+1} - the row with the smallest sum {sumLine} of elements.");

int[,] CreateRandom2DArrayInt()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void Show2dArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write($"[ {array[i, j]} ");
            else if (j == array.GetLength(1) - 1)
                Console.WriteLine($"{array[i, j]} ]");
            else
                Console.Write($"{array[i, j]} ");
        }
    }
}
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
/*
void MatrixMultiply(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i,k] * secondMatrix[k,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
}
Console.WriteLine("Enter size matrix.");
Console.Write("Enter number of lines first matrix: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of row first matrix (and lines second matrix).");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of row second matrix.");
int c = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = CreateMatrixRandom2DArrayInt(a, b);
int[,] secondMatrix = CreateMatrixRandom2DArrayInt(b, c);
int[,] resultMatrix = new int[a, c];
Console.WriteLine("\r\nFirst matrix:");
Show2dArrayInt(firstMatrix);
Console.WriteLine("\r\nSecond matrix:");
Show2dArrayInt(secondMatrix);
MatrixMultiply(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("\r\nOp. of the first and second matrix.");
Show2dArrayInt(resultMatrix);

int[,] CreateMatrixRandom2DArrayInt(int columns, int rows)
        {
            Console.Write("Min 1, input a max possible value: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = new Random().Next(1, max + 1);
                }
            }
            return array;
        }
void Show2dArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write($"[ {array[i, j]} ");
            else if (j == array.GetLength(1) - 1)
                Console.WriteLine($"{array[i, j]} ]");
            else
                Console.Write($"{array[i, j]} ");
        }
    }
}
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0, 0, 0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)
/*
CreateArray();
void CreateArray()
{
    Console.Write("Input a number of x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of z: ");
    int z = Convert.ToInt32(Console.ReadLine());
    CreateRandom3DArrayInt(x, y, z);
}
void CreateRandom3DArrayInt(int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    if (temp.Length < 100)
    {
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 100);
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (temp[i] == temp[j])
                    {
                        temp[i] = new Random().Next(10, 100);
                        j = 0;
                    }
                }
            }
        }
        int count = 0;
        for (int a = 0; a < array3D.GetLength(0); a++)
        {
            for (int b = 0; b < array3D.GetLength(1); b++)
            {
                for (int c = 0; c < array3D.GetLength(2); c++)
                {
                    array3D[a, b, c] = temp[count];
                    count++;
                }
            }
        }
        Show3dArrayInt(array3D);
    }
    else
    {
        Console.WriteLine("The matrix came out more than 100 numbers.");
    }
}
void Show3dArrayInt(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (k == 0)
                    Console.Write($"[ {array[i, j, k]}({i},{j},{k}) ");
                else if (k == array.GetLength(2) - 1)
                    Console.WriteLine($"{array[i, j, k]}({i},{j},{k}) ]");
                else
                    Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
*/

//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
/*
Console.Write("Enter a number from 1 to 9: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] spiralMatrix = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
    spiralMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}
PrintArray(spiralMatrix);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array.GetLength(0) >= 10)
            {
                if (array[i, j] / 10 <= 0)
                {
                    if (array[i, j] < 10)
                        Console.Write($"00{array[i, j]} ");
                    else if (array[i, j] >= 10 && array[i, j] < 100)
                        Console.Write($"0{array[i, j]} ");
                }
                else if (array[i, j] >= 10 && array[i, j] < 100)
                    Console.Write($"0{array[i, j]} ");
                else
                    Console.Write($"{array[i, j]} ");
            }
            if (array.GetLength(0) < 10)
            {
                if (array[i, j] / 10 <= 0)
                    if (array[i, j] < 10)
                        Console.Write($"0{array[i, j]} ");
                    else
                        Console.Write($" {array[i, j]} ");
                else if (array[i, j] < 10)
                    Console.Write($"0{array[i, j]} ");
                else
                    Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
*/