// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();


int[] CreateRandomArray(int number)
{
    int sum = 0;
    int[] randomArray = new int[number];
    for (int i = 0; i < number; i++)
    {
        randomArray[i] = new Random().Next(99, 999);
    }
    for (int i = 0; i < number; i++)
    {
        if (randomArray[i] % 2 != 0)
        {
            sum++;
        }
        else break;
    }
    Console.WriteLine($"[{String.Join(", ", randomArray)}]");
    return randomArray;
    return sum;
}

