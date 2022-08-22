/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76
*/

double[] GetArray()
{
    Console.WriteLine("Задайте размер масссива:");
    int size = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите элементы массива:");
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = double.Parse(Console.ReadLine());
    }
    return array;
}

double FindMinMax(double[] mas)
{
    double min = mas[0];
    double max = mas[0];
    for(int i = 1; i < mas.Length; i++)
    {
        if(min > mas[i]) min = mas[i];
        if(max < mas[i]) max = mas[i];
    }
    double result = max - min;
    return result; 
}

double[] arr = GetArray();
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(FindMinMax(arr));


