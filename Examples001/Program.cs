Console.Clear();
// Первый тип метода: ниего не принимает, и ничего не возвращает (void)
/*
void Method1() {
    Console.WriteLine("Первая группа методов");
}
Method1(); // Вызов метода происходит таким образом
Console.WriteLine();
*/
// Второй тип метода: что-то принимает, но ничего не возвращает (void)
/*
void Method20(string msg) {
    Console.WriteLine(msg);
}
Method20(msg:"Вторая группа методов - принимает на вход строку");

void Method21(string msg, int count) {
    int i = 0;
    while (i < count) {
        Console.WriteLine(msg);
        i++; // инкримент ++ декримент --
    }
}
Method21(msg:"Вторая группа методов - принимает на вход строку", count: 3);
Method21(count: 2, msg:"Вывод можно делать и так");
Console.WriteLine();
*/
// Третий тип метода: ничего не принимает, но что-то возвращает (например - генерировать случайные данные)
/*
int Method3(){
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine($"Третья группа методов, не принимает, но возвращает {year}");
Console.WriteLine();
*/
// Четвертый тип метода: что-то примают, и что-то возвращют
/*
string Method4(int count, string text) {
    int i = 0;
    string result = String.Empty;
    while(i < count) {
        result = result + text;
        i++;
    }
    return result;
}
//Console.WriteLine(Method4(3, "method4\n"));
string str = Method4(3, "Вывод 4-го метода\n");
string s = Method4(text: "Или такой вывод 4-го метода\n", count: 2);
Console.WriteLine(str);
Console.WriteLine(s);
*/
// Цикл в цикле
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.Write($" {i} * {j} = {i*j} ");
    }
    Console.WriteLine();
}
*/
// Задача 1:

string text = " - Я думаю, сказал князь, улыбаясь, - что, " +
              "ежели бы вас послали вместо нашего милого Винценгероде, "
              + "вы бы взяли приступом согласие прусского короля." +
               "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty";
//            012345
//s[3] = r;
/*
string Replace(string text, char oldValue, char newValue){
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|'); // именно одинарные ковычки
Console.WriteLine(newText);
Console.WriteLine();
string newString = Replace(text, 'и', 'И');
Console.WriteLine(newString);
*/

// Задача 2:

int[] array = { 1, 8, 3, 2, 6, 4, 5, 7 };
void PrintArray(int[] array) {
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionArray(int[] array){
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temprory = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprory;
    }
}
PrintArray(array);
SelectionArray(array);
PrintArray(array);
