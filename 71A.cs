
int numOfWords = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfWords; i++)
{
    int count = -2;
    string str = Console.ReadLine();
    if (str != null && str.Length > 10)
    {
        foreach (char s in str)
            ++count;

        char firstLetter = str[0];
        char lastLetter = str[str.Length - 1];

        string newStr = firstLetter + count.ToString() + lastLetter;

        Console.WriteLine(newStr);

    }
    else if (str != null)
    {
        Console.WriteLine(str);
    }
}


