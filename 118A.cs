//replace all uppercase consonant with lower case one
string word = Console.ReadLine().ToLower();

List<char> wordChar = new List<char> {};

foreach (char letter in word)
{
    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y')
        //delete all vowels
        continue;
    else
    {
        //insert '.' before each consonant
        wordChar.Add('.');
        wordChar.Add(letter);
    }
}

foreach (char letter in wordChar)
    newWord += letter;

Console.WriteLine(newWord);
