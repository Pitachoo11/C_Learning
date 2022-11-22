// Упорядочивание массива

int[] array = {1, 5, 4, 3, 2, 6, 7, 1, 1, 1};

void PrintArray(int[] array)
{
     int count = array.Length;
     for (int i = 0; i < count; i++)
     {
        System.Console.Write($"{array[i]} ");
     }
    System.Console.WriteLine();
}

void ArrayOrder(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }

}

PrintArray(array);

ArrayOrder(array);
PrintArray(array);
