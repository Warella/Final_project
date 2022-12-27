// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
string[] CreateShortArray(string[] startArray)
{
    int count = 0;
    int length = startArray.Length;
    string[] resultArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        if (startArray[i].Count() <= 3) 
        {
            resultArray[count] = startArray[i];
            count++;
        }
    }
    Array.Resize(ref resultArray, count);
    return resultArray;
}
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Array is empty");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}
string[] startArray = { "yo!", "I'am", "Lera", "and", "you", "?" };
string[] result = CreateShortArray(startArray);
PrintArray(result);