
void FillArray(int[,] numarray)
{
    for (int rows = 0; rows < numarray.GetLength(0); rows++)
    {
        for (int columns = 0; columns < numarray.GetLength(1); columns++)
        {
            numarray[rows, columns] = new Random().Next(1, 10);
        }
    }
} 

void PrintArray(int[,] numarray)
{
    for (int rows = 0; rows < numarray.GetLength(0); rows++)
    {
        for (int columns = 0; columns < numarray.GetLength(1); columns++)
        {
            System.Console.Write($"{numarray[rows, columns]} ");
        }
    System.Console.WriteLine();
    }
} 

int[,] matrix = new int[3,4];

PrintArray(matrix);

FillArray(matrix);
System.Console.WriteLine();

PrintArray(matrix);