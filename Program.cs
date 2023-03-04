/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

/* 
Console.WriteLine($"Введите размер массива: ");
int lenArray = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[lenArray];
FillAray(randomArray);
String.Join(", ", randomArray);
Console.Write($"[{String.Join(", ", randomArray)}]");
FindEven(randomArray);

void FillAray(int[] randomArray)
{
    for(int i = 0; i < randomArray.Length; i++)
        randomArray[i] = new Random().Next(100,1000);
}

void FindEven(int[] randomArray)
{
    int even = 0;
    for(int j = 0; j < randomArray.Length; j++)
        if (randomArray[j] % 2 == 0)
    even++;
    Console.WriteLine($" -> {even} чётные");
}
 */

/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

/* 
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
 */

/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
 */

/* 
Console.WriteLine($"Введите размер массива: ");
int lenArray = int.Parse(Console.ReadLine()!);
double[] randomArray = new double[lenArray];
FillArray(randomArray);
String.Join(", ", randomArray);
Console.Write($"[{String.Join(", ", randomArray)}]");

double minValue = Int32.MaxValue;
double maxValue = Int32.MinValue;

for (int j = 0; j < randomArray.Length; j++)
{
    if (randomArray[j] > maxValue)
        maxValue = randomArray[j];
    if (randomArray[j] < minValue)
        minValue = randomArray[j];
}

Console.WriteLine($" -> {maxValue - minValue}");

void FillArray(double[] randomArray)
{
    for(int i = 0; i < randomArray.Length; i++)
        randomArray[i] = Convert.ToDouble(new Random().Next(1, 10000));
}
 */