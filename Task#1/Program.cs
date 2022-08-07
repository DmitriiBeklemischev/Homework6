//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int getBigO( int[] arr )
{
    int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>0) res++;
    
}
 return res;
}


Console.WriteLine("Введите количество чисел");
int col = int.Parse(Console.ReadLine());
int[] array = new int[col];

for (int i = 0; i < col; i++)
{
    Console.WriteLine($"Введите {i+1}е чиселo:");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Сумма четных чисел = {getBigO( array )}");