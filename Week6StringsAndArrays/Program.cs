string hello = "w hello, world! ";

int stringLength = hello.Length;

//string trimmedString = hello.Trim();
hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace(' ', '_');

firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);

int wordCount = 1;

for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    {
        wordCount++;
    }
}

Console.WriteLine($"Word count: {wordCount} words.");