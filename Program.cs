using static System.Console;
Clear();

Write("Введите массив строк через \",\" или пробел: ");
string[] arr=ReadLine()!.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);


Write(string.Join(", ", arr));
