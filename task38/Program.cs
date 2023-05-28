// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,100);
        }
}

PrintArray(numbers);
void PrintArray(int[] numbers)
{
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
       Console.WriteLine();
}
int min = numbers[0];
int max = numbers[0];

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
Console.WriteLine($"Разница между макс и мин = {max - min}");




