﻿// Вычисление факториала числа N через рекурсию

int Factorial(int N)
{
    if (N == 1)
    {
       return 1; 
    }
    else
    {
        return N * Factorial(N-1);
    }
}

System.Console.WriteLine(Factorial(5));