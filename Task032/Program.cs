/*  Напишите программу замена элементов массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] ReveresArray(int[] mas)
{
    for(int i = 0; i < mas.Length; i++)
    {
        mas[i] *= -1;
    }
    return mas;
}

int[] arr = GetArray(4, -10, 10);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(String.Join(" ", ReveresArray(arr)));
