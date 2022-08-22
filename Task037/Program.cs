/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,  
второй и предпоследний, и т.д. Результат запишите в новом массиве
[1 2 3 4 5] - 5 8 3
[6 7 3 6] - 36 21
*/

int[] GetArray()
{
    Console.WriteLine("Задайте размер масссива:");
    int size = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите элементы массива:");
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

// int[] MultiArr(int[] mas)
// {
//     int newSize = mas.Length % 2 == 0 ? mas.Length / 2 : mas.Length / 2 + 1;
//     int[] newMas = new int[newSize];
//     int s = mas.Length - 1;
//     for(int i = 0; i < newSize; i++)
//     {
//         if(mas.Length % 2 != 0)
//         {

//         }
//         else 
//         {
//             newMas[i] = mas[i] * mas[s];
//         }
//         s--;
//     }
//     return newMas;
// }

int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for(int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
    return result;
}

int[] arr = GetArray();
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(String.Join(" ", ResultArray(arr)));