void WordsUnderThreeSymbols(string[] words)
{
    string[] strings = new string[2];
    int j = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            strings[j] = words[i];
            Console.Write(strings[j] + "    ");
            j++;          
        }
    }
}

string [] words = {"Hello", "2", "world", ":-)" }; 

WordsUnderThreeSymbols(words);