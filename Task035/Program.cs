// Задайте одномерный массив из 123 случайных чисел. Найдтие количесвто элементов массива, значения которых лежат
//в отрезке [10, 99]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i =0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int CountMas(int[] mas, int minValue, int maxValue)
{
    int count = 0;
    for(int i = 0; i < mas.Length; i++)
    {
        if(mas[i] >= minValue && mas[i] <= maxValue) count ++;
    }
    return count;
}

int[] array = GetArray(123, -100, 100);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(CountMas(array, 10, 99));
