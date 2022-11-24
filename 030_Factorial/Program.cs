// Вычисление факториала числа N через рекурсию

double Factorial(int N)
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
for (int i = 1; i < 20; i++)
{
  Console.WriteLine($"{i}! = {Factorial(i)}");  
}
