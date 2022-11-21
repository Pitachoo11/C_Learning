//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int x = new Random().Next(100,999);
System.Console.WriteLine(x);
int position = 2; //какую цифру удаляем
int m = 1;
while (position > 1)
{
     m *= 10;
     position--;
}
int t = (x % m) + (x / (m * 10)) * m;
Console.WriteLine(t);