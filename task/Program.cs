// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Write("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());

while (size < 0)
{
    Console.Write("Вы ввели в качестве размера массива отрицательное значение. Введите заново размер массива:");
    size = int.Parse(Console.ReadLine());
}

string[] array = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите значение {i + 1} элемента массива: ");
    array[i] = Console.ReadLine();
}

Console.WriteLine($"Введенный вами массив [{string.Join(", ", array)}]");

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}

string[] array2 = new string[count];

int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array2[j] = array[i];
        j++;
    }
}
Console.Write($"Новый массив из строк, длина которых меньше, либо равна 3 символам [{string.Join(",", array2)}]");