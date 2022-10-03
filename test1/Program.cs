// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с кравиатуры, либо задать на старте выполнения алгоритма.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "somputer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Введиде длину массива");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

if (!isNumberM || m < 1)
{
    Console.WriteLine("Вы ввели неверную размерность массива. Число должно быть больше 1.");
    return;
}

string[] CreateArray(int m)
{
    string[] array = new string[m];
    
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива.");
        var ii = Console.ReadLine();
        ii = ii is null ? "" : ii;
        array[i] = ii;
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}

int CountElementsWithMaxThreeSybolsInArray(string[] array)
{
    int newArrayLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        newArrayLength = array[i].Length <= 3 ? newArrayLength+1 : newArrayLength;
    }
    return newArrayLength;
}

string[] GetMaxThreeSymbolsArray(string[] array, int newArrayLength)
{
    string[] result = new string[newArrayLength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string[] array = CreateArray(m);
PrintArray(array);
Console.WriteLine();
int newArrayLength = CountElementsWithMaxThreeSybolsInArray(array);
if (newArrayLength == 0)
{
    Console.WriteLine("У вашего массива нет ни одного искомого элемента, который содержит 3 или менее символов.");
}
else
{
    string[] result = GetMaxThreeSymbolsArray(array, newArrayLength);
    Console.WriteLine();
    PrintArray(result);
}