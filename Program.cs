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

int[,] myarr1 = GetIntArray(3, 3);
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
else PrintIntArray(MultiplyArr(myarr1, myarr2));


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