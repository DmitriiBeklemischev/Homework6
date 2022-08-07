//Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.


int[] GetArray(int size, int min, int max)
{
    while (max < min)  // сделал пререопределение min и max, в случае неправильного ввода
    {
        int c = max;
        max = min;
        min = c;
    }

    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }

    return result;
}


void reversArray(int[] array, int[] array2)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int k = array[i];
        array2[i] = array[array.Length - i - 1];
        array2[array.Length - i - 1] = k;
    }
}

Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");
int max = int.Parse(Console.ReadLine());


Console.WriteLine();
int[] array = GetArray(length, min, max);
int[] arrayCopy = new int[array.Length];

Console.WriteLine(String.Join(" ", array));
reversArray(array, arrayCopy);
Console.WriteLine(String.Join(" ", arrayCopy));


