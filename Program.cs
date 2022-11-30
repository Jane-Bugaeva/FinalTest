/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] CreateArray() 
{
  Console.Write("Задайте длинну массива: ");
  int size = Convert.ToInt32(Console.ReadLine());
  string[] array = new string[size];
    for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine();
  }
    return array;
}

void ShowArray(string[] array) 
{
  foreach (var item in array)

    Console.Write($"{item} ");
}

string[] ThreeSimbolMethod(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            count++;
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    return newArray;
}

string[] strArray = CreateArray();
Console.Write("-> [");
ShowArray(ThreeSimbolMethod(strArray));
Console.Write("]");
