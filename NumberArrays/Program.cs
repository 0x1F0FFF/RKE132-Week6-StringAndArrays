﻿int[] numbers = new int[1000];
Random rnd = new Random();

int sum = 0;

// populating array
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, numbers.Length + 1);
    sum = sum + numbers[i];
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");