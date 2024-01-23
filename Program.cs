// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

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