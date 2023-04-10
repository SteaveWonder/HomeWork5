// Task 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] RandomNumberArray(int LenghtArray)
// {
//     int[] SomeArray = new int[LenghtArray];
//     for (int i = 0; i < SomeArray.Length; i++)
//     {
//         SomeArray[i] = new Random().Next(99, 999);
//     }
//     return SomeArray;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("Your array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int EvenNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }
// Console.Write("Input length your array: ");
// int LenghtArray = Convert.ToInt32(Console.ReadLine());

// int[] array = RandomNumberArray(LenghtArray);

// PrintArray(array);
// Console.Write($"Even numbers in array: {EvenNumbers(array)}");




// Task 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

// int[] RandomNumberArray(int LenghtArray)
// {
//     int[] SomeArray = new int[LenghtArray];
//     for (int i = 0; i < SomeArray.Length; i++)
//     {
//         SomeArray[i] = new Random().Next(1, 10);
//     }
//     return SomeArray;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("Your array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int SomOddNumbers(int[] array)
// {
//     int sum = 0;
//     int i = 0;
//     while (i < array.Length)
//     {
//         sum = sum + array[i];
//         i = i + 2;
//     }
//     return sum;
// }

// Console.Write("Input length your array: ");
// int LenghtArray = Convert.ToInt32(Console.ReadLine());

// int[] array = RandomNumberArray(LenghtArray);

// PrintArray(array);
// Console.Write($"Sum odd numbers in array: {SomOddNumbers(array)}");



// Task 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double min = Int32.MaxValue;
double max = Int32.MinValue;
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
void ArrayRandom(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(10, 100)) / 10;
    }
}
void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input size mas");
Console.WriteLine($"All {numbers.Length}. MAX = {max}, MIN = {min}");
Console.WriteLine($"Difference between MAX & MIN = {max - min}");
ArrayRandom(numbers);
PrintArray(numbers);
