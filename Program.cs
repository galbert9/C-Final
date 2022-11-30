// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3
// символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Создание массива на старте
string[] array = new string[] {"Hello", "2", "world", ":-)"};
string[] arrayNew = new string[array.Length];

// Обертка Method2
void NewArray()
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arrayNew[j] = array[i];
        j++;
        }
    }
}
// Обертка Method2
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray();
PrintArray(arrayNew);