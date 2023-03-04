/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

Console.WriteLine($"Введите размер массива: ");
int lenArray = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[lenArray];
FillAray(randomArray);
String.Join(", ", randomArray);
Console.Write($"[{String.Join(", ", randomArray)}]");
PrintArray(randomArray);

void FillAray(int[] randomArray)
{
    int minValue = -2147483648;
    int maxValue = 2147483647;
    for(int i = 0; i < randomArray.Length; i++)
        randomArray[i] = new Random().Next(minValue, maxValue);
}

void PrintArray(int[] randomArray)
{
    int sum = 0;
    for(int j = 0; j < randomArray.Length; j+=2)
        sum = sum + randomArray[j];
    Console.WriteLine($" -> {sum}");
}
