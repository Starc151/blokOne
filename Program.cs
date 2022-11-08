using static System.Console;
Clear();

string[] GetStringArrMoreThree(string[] inArr){
    string tmpStr="";
    foreach(string i in inArr){
        if(i.Length<=3)tmpStr+=i+" ";
    }
    return tmpStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
}
Write("Введите массив строк через пробел: ");
string[] arr=ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Введённоый массив: [\"{string.Join("\" \"", arr)}\"]");
WriteLine($"Полученный массив с элементами 3 или меньше: [\"{string.Join("\" \"", GetStringArrMoreThree(arr))}\"]");
