using static System.Console;
Clear();

string[] GetStringArrMoreThree(string[] inArr){
    string tmpStr="";
    foreach(string i in inArr){
        if(i.Length<=3)tmpStr+=i+" ";
    }
    return tmpStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
}
Write("Введите массив строк через \",\" или пробел: ");
string[] arr=ReadLine()!.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
Write(string.Join(", ", arr));
WriteLine();
WriteLine(string.Join(", ", GetStringArrMoreThree(arr)));
