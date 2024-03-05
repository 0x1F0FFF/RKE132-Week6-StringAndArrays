string[] snacks = { "food", "stone", "glass" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"We're going to eat {snacks[randomIndex]}");