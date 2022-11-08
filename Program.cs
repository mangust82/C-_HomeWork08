// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

/*int[,] myarr = GetIntArray(5, 8);
PrintIntArray(myarr);
Console.WriteLine();
PrintIntArray(SortRowArr(myarr));*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

int[,] myarr = GetIntArray(8, 4);
PrintIntArray(myarr);
Console.WriteLine();
Console.WriteLine(IndexSumMin(myarr));


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
            array[i, j] = new Random().Next(0, 101);

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