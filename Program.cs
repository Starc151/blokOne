using static System.Console;
Clear();
string GetStringArrMoreThree(string[] inArr){
    string str="";
    foreach(string i in inArr){
        if(i.Length<=3)str+=i;
    }

    return str;
}
Write("Введите массив строк через \",\" или пробел: ");
string[] arr=ReadLine()!.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
Write(string.Join(", ", arr));
WriteLine();
WriteLine(GetStringArrMoreThree(arr));
