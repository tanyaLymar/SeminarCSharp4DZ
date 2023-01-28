// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillMas (int[]array)
{
   for (int i = 0; i < array.Length; i++)
    {
        int value = new Random().Next(1,100);
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
int sum = 0;

FillMas(array);
PrintMas(array);

for (int i = 1; i < array.Length; i+=2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Сумма элементов стоящих на нечетной позиции равна {sum}");