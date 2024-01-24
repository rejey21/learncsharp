// Создание строки
// Первый вариант
// string s1 = "hello";

// Второй вариант
// char[] ch_array = { 'w', 'o', 'r', 'l', 'd'};
// string s2 = new String(ch_array);

// Третий вариант
// string s3 = new string('a', 6); // Результатом будет строка - "aaaaaa" 

string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);