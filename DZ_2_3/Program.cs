//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

Console.Write("Введите номер дня недели 1-7: ");

int DayNumber = Convert.ToInt32(Console.ReadLine());

if (DayNumber == 6 || DayNumber == 7)
{
    Console.WriteLine("Выходной день");
}
else if (DayNumber > 7 || DayNumber < 1)
{
    Console.WriteLine("Ошибка ввода дня недели!");
}
else
{
    Console.WriteLine("Будний день");
}