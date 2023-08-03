/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

  void ResultArray (int [,] array2d)
{   
    
   
    for (int j = 0; j < array2d.GetLength(1); j++ )
    {  
     double    sum = 0;
    double result = 0; 
           
         for  (int i = 0; i < array2d.GetLength(0); i++)
        {               
                                 
           sum += array2d[i,j];        
        }
                  
         result = Math.Round(sum/array2d.GetLength(0),2);
           Console.Write(result + ", ");            
    }   
      
        
    
}

   ResultArray(array_2d);

