/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
 */

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
