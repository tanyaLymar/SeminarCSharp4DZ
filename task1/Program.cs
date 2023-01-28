/* Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.*/
 void FillMas (int[]array)
{
   for (int i = 0; i < array.Length; i++)
    {
        int value = new Random().Next(100,1000);
        array[i] =value;
    }
}

void PrintMas(int [] array)
{
    foreach(int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
    
Console.Write("Введите размерность массива: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
int [] array = new int[n];

FillMas(array);
PrintMas(array);

int count = 0;

foreach(int item in array)
{
    if(item%2 == 0)
    {
        count++;
    }
    else continue;
}
Console.WriteLine($"Четные значения встречаются в массиве {count} раз.");
