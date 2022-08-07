// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void enteringAvalue(double[] ar)
{     //          b2      b1        k1      k2
    double x = (ar[1] - ar[0]) / (ar[2] - ar[3]);                      //  y = k1 * x + b1, y = k2 * x + b2;
     //          k1         b1                                         //  k1*x+b1=k2*x+b2
    double y = ar[2] * x + ar[0];                                      //  x=(b2-b1)/(k1-k2)
    Console.WriteLine($"Точка пересечения = ({x};{y})");            
}



double[] array = new double[4];
for (int i = 0; i < 2; i++)
{ 
    Console.WriteLine($"Введите b{i + 1} :");
    array[i] = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
    Console.WriteLine($"Введите k{i + 1} :");
    array[i + 2] = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);

}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]} - {i} ");
}



enteringAvalue(array);


