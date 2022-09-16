// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше, либо равна 3 символа.

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "");
//string[] array = CreateArray(size);
Console.Write(String.Join(",", CreateArray(size)));

string[] CreateArray(int length)
{
    string[] arr = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите строчный элемент массива: ");
        arr[i] = Console.ReadLine() ?? "";
    }
    return arr;
}


