// Парсинг текстового ввода
// Взять на вход текстовые значения координат и увеличить каждое в два раза 

using System.Linq;

string text = "(1,2) (2,3) (3,4) (4,5)" //ввод текстовых значений
                .Replace ("(", "") // удалить символ "("
                .Replace (")", ""); // удалить символ ")"

System.Console.WriteLine(text); // отобразить промежуточный результат

var data = text.Split(" ") // разделить текст по сепаратору " " пробел
                .Select(item => item.Split(',')) // сделать выборку элементов по разделителю ","
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // сделать выборку и присвоить x ЧИСЛЕННОЕ значение первого элемента, y - второго элемента
                .Where(e => e.x % 2 == 0) // сделать выборку только четных элементов (пар, где первое значение четное)
                .Select(point => (point.x * 2, point.y)) // для отобранных эелементов увеличить координату x в 2 раза
                .ToArray(); // сформировать массив из отобранных к этому шагу значений, data[i] - уже ЧИСЛЕННЫЙ массив

for (int i = 0; i < data.Length; i++)
{
    System.Console.WriteLine(data[i]);
    //for (int k = 0; k < data[i].Length; k++)
    //{
    //   System.Console.WriteLine(data[i][k]);
    //}
    Console.WriteLine();
}
