// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
/*
string GetStringFrmChar (char [,] array)
{
    string str = " ";
    for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
    {
      str += array[i,j];
    }
    return str;
}

char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
string res = GetStringFrmChar(charArray);
Console.WriteLine((res));

*/

// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
/*
string input = "aBcD1fGi23";
string result = input.ToLower();
Console.WriteLine (result);
*/


//Задайте произвольную строку. Выясните, является ли она палиндромом.
/*
public class Task3
{
public static void Main(string[] args)
{
string input = "шалаш";
Console.WriteLine(isPalindrome ? "Да" : "Нет");
}


string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return normalized.SequenceEqual(normalized.Reverse());
}
*/
/*
//Проверка строки на палиндром

bool IsPalindrome(string str)
{
  string normalized = new string (str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
  return normalized.SequenceEqual(normalized.Reverse());
}

string main = "шалаш";
bool isPalindrome = IsPalindrome(main);
Console.WriteLine(isPalindrome ? "Да" : "Нет");
