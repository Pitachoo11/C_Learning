﻿//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number1 % 7 == 0 && number1 % 23 == 0 ? "Число кратно 7 и 23" : "Число не кратно 7 и 23");