/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

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
