/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int [,] Array_2d (int line, int columns, int leftEdge, int rightEdge)
{
    int [,] my2dArray = new int[line,columns];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            my2dArray[i,j] =  new Random().Next(leftEdge, rightEdge + 1);
        }
    }
    return my2dArray;
}

void Show2dArray (int [,] array2dPrint)
{
    for (int i = 0; i < array2dPrint.GetLength(0); i++)
    {
        for (int j = 0; j < array2dPrint.GetLength(1); j++)
        {
            Console.Write(array2dPrint[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter your number for line ");
int numbLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your number for columns ");
int numbColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your leftEdge: ");
int leftEdgeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your rightEdge: ");
int rightEdgeArray = Convert.ToInt32(Console.ReadLine());
int [,] array_2d = Array_2d(numbLine,numbColumns,leftEdgeArray,rightEdgeArray);
Show2dArray(array_2d);
void PrintResult (int [,] print2dArray)
{
        Console.WriteLine("Enter your number for your line output ");
        int my_numbLine = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your number for your columns output ");
        int my_numbColumns = Convert.ToInt32(Console.ReadLine());
        int result = 0;
    if (my_numbLine < numbLine && my_numbColumns < numbColumns)
    {
        result = print2dArray[my_numbLine,my_numbColumns];
        Console.WriteLine($"number in your position {result}" );
    }
    else
    {
        Console.WriteLine("No such position exists in your array");
    }
          
}
PrintResult(array_2d);
