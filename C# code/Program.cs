// Написать программу, которая из имеющегося массива сток формирует масиив из строк, длина которых меньше, дибо равна 3 символа

string[] ImputArray(string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine()!.Split();
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

string[] LengthCheck(string[] array)
{
    string[] result = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

string[] myArr = ImputArray("Input array");
myArr = LengthCheck(myArr);
System.Console.WriteLine();
PrintArray(myArr);