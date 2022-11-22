//  Задача по замене символов в тексте
// Заменить все пробелы на символ -
// Заменить все к на К
// Заменить все С на с


string text = "– Я думаю, – сказал князь, улыбаясь, – что," 
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty";
//             012345
//s[3] // r

string Replace(string text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string NewText = Replace(text, ' ', '_');
System.Console.WriteLine(NewText);

System.Console.WriteLine();

NewText = Replace(NewText, 'к', 'К');
System.Console.WriteLine(NewText);

System.Console.WriteLine();

NewText = Replace(NewText, 'Я', 'я');
System.Console.WriteLine(NewText);