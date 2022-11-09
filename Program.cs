// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

/*int[,] myarr = GetIntArray(5, 8);
PrintIntArray(myarr);
Console.WriteLine();
PrintIntArray(SortRowArr(myarr));*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

/*int[,] myarr = GetIntArray(8, 4);
PrintIntArray(myarr);
Console.WriteLine();
Console.WriteLine(IndexSumMin(myarr));*/

// Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух 
// матриц.

/*int[,] myarr1 = GetIntArray(3, 3);
int[,] myarr2 = GetIntArray(3, 4);
PrintIntArray(myarr1);
Console.WriteLine();
PrintIntArray(myarr2);
Console.WriteLine();
if (myarr1.GetLength(0) != myarr1.GetLength(1) || myarr2.GetLength(0) != myarr2.GetLength(1) 
|| myarr1.GetLength(0) != myarr2.GetLength(1) )
{
    Console.WriteLine("Матрицы не согласованы");
}
else PrintIntArray(MultiplyArr(myarr1, myarr2));*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.Массив размером 2 x 2 x 2

/*int[,,] myarr = GetThreeArray(2,2,2);
PrintThreeArray(myarr);*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*PrintSpiralArray(Snake(4,4));*/

// Задача 59: Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с 
// отсортированными нечетными столбцами

int[,] myarr = GetIntArray(5, 8);
PrintIntArray(myarr);
Console.WriteLine();
PrintIntArray(SortColArr(myarr));


// ***************** Methods *****************************************************************

int[,] SortColArr(int[,] array)
{
   int temp = 0;
   for(int j=1; j<array.GetLength(1); j+=2)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int k = i + 1; k < array.GetLength(0); k++)
            {
                if (array[i,j] > array[k,j])
                {
                    temp = array[i,j];
                    array[i,j] = array[k,j];
                    array[k,j] = temp;
                }
            }
        }
    }
    return array;
}

int[,,] GetThreeArray(int m, int n, int p)
{
    int[,,] array = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k=0; k < p; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void PrintThreeArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,] MultiplyArr(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                result[i,k] = result[i,k] + array1[i,j] * array2[j,k];
            }
        }
    }
    return result;
}

int IndexSumMin(int[,] array)
{
    int summin = 0;
    int minindex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        Console.WriteLine(sum);
        if (i == 0) 
        {
            summin = sum;
            minindex = i;
        }
        if (sum < summin)
        {
            summin = sum;
            minindex = i;
        } 
        
    }
    return minindex;
}

int[,] GetIntArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 100);

        }
    }
    return array;
}

void PrintIntArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortRowArr(int[,] array)
{
   int temp = 0;
   for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}

void PrintSpiralArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j].ToString("000")} ");
        }
        Console.WriteLine();
    }
}

int[,] Snake(int row, int col)
{
    int j = 0; //строки
    int i = 0; //столбцы
    int n = 0; //счетчик общего количества элементов
    int k = 1; //счетчик уменьшения индекса строки столбца при проходе
    int p = 0; //счетчик уменьшения индекса строки при движении вверх
    int[,] array = new int[row,col];
    int M = array.GetLength(1)*array.GetLength(0);
    while(n < array.GetLength(1)*array.GetLength(0)-1)
    {
        
        for ( ; i < array.GetLength(1)-k ; i++, n++)
            {
                if (n >= M) break;
                array[j,i] = n;
                
            }
        for ( ; j < array.GetLength(0)-k; j++, n++)
            {
                if (n >= M) break;
                array[j,i] = n;
            }
        
        for ( ; i > p; i--, n++)
            {
                if (n >= M) break;
                array[j,i] = n;
            }
            
        for ( ; j >k; j--, n++)
            {
                
                if (n >= M) break;
                array[j,i] = n;
            }
        k++;
        p++;   
    }
    array[j,i] = n;
    return array;
}
