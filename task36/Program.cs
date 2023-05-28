//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int sum = 0;
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

for (int i = 0; i < numbers.Length; i++) {
    if (i % 2 != 0)
    {
       sum = sum + numbers[i]; 
    }
}
    Console.WriteLine($"сумма элементов на нечётных позициях {sum}");
return sum;

