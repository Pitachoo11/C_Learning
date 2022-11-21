//дано натуральное n. вычислить: 1 + 1/2 + 1/3 + 1/4 + ... + 1/n.

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
double s = 0;

for (double i = 1; i <= n; i++)
{
   s=s+(1/i);
}
Console.WriteLine(s);