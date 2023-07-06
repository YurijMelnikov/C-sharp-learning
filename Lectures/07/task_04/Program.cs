int n = 1;
void Word (string alphabet, char[] word, int length = 0)
{    
    if (length == word.Length)
    System.Console.WriteLine($"({n++}, {new String(word)})");
    else
    {
        for (int i = 0; i < alphabet.Length; i ++)
        {
            word[length] = alphabet[i];
            Word (alphabet, word, length + 1); 
        }
    }
}
Word("abcdifg", new char[5]);