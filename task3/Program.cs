// Массив вещественных чисел. Разница между максимальным и минимальным значениями.
void FillMas (double[]array)
{
   for (int i = 0; i < array.Length; i++)
    {
        double value = Convert.ToDouble(new Random().Next(100)/10.0);
        array[i] = value;
    }
}

void PrintMas(double [] array)
{
    foreach(double item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
    
Console.Write("Введите размерность массива: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
double [] array = new double[n];

FillMas(array);
PrintMas(array);

double max = 0;
double min = array[0];

foreach(double item in array)
{
    if(item > max) max = item;
    else if(item < min) min = item;
    else continue;
}
Console.WriteLine($"Максимальное значение массива равно {max}");
Console.WriteLine($"Минимальное значение массива равно {min}");
Console.WriteLine($"Разница между максимальным и минимальным значениями массива равна {max-min}");
