﻿//string[] fruit = { "apples", "bananas", "oranges" };
string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananans";
fruit[2] = "oranges";

int fruitArrayLength = fruit.Length;
Console.WriteLine(fruitArrayLength);

for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string element in fruit)
{
    Console.WriteLine(element);
}