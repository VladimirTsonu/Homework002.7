/* 
. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double [,] Array_2d (int line, int columns, int leftEdge, int rightEdge)
{
    double [,] my2dArray = new double[line,columns];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            my2dArray[i,j] =  Math.Round((new Random().Next(leftEdge, rightEdge + 1) + new Random().NextDouble()),2);
        }
    }
    return my2dArray;
}

void Show2dArray (double [,] array2dPrint)
{
    for (int i = 0; i < array2dPrint.GetLength(0); i++)
    {
        for (int j = 0; j < array2dPrint.GetLength(1); j++)
        {
            Console.Write(array2dPrint[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Enter your number for line ");
int numbLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your number for columns ");
int numbColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your leftEdge: ");
int leftEdgeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your rightEdge: ");
int rightEdgeArray = Convert.ToInt32(Console.ReadLine());
double [,] array_2d = Array_2d(numbLine,numbColumns,leftEdgeArray,rightEdgeArray);
Show2dArray(array_2d);