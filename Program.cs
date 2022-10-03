// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше или равна 3 символа
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алшоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"]->["2", ":-)"]
// ["1234", "1567", "-2", "computer science"]->["-2"]
// ["Russia", "Denmark", "Kazan"]->[]

string[] array1 = EnterArray();
string[] array2 = new string[array1.Length];

string[] EnterArray()
{
    Console.Write("Введите значения через пробел: ");
    return  Console.ReadLine().Split(" ");
}

void OutputArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

OutputArray(array1, array2);
PrintArray(array2);