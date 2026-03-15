namespace Computer_Science_Calculator;

public class Tokenizer
{
    public static Queue Tokenize(string input)
    {
        Queue tokens = new Queue();
        string numberBuffer = "";
        string wordBuffer = "";
        foreach (char s in input)
        {
            if (char.IsDigit(s)) 
            {
                numberBuffer += s;
            }
            else if (char.IsLetter(s))
            {
                wordBuffer += s;
            }
            else if (s == ' ')
            {
                if (numberBuffer != "")
                {
                    tokens.Enqueue(numberBuffer);
                    numberBuffer = "";
                }
                if (wordBuffer != "")
                {
                    tokens.Enqueue(wordBuffer);
                    wordBuffer = "";
                }
            }
            else
            {
                if (numberBuffer != "")
                {
                    tokens.Enqueue(numberBuffer);
                    numberBuffer = "";
                }
                if (wordBuffer != "")
                {
                    tokens.Enqueue(wordBuffer);
                    wordBuffer = "";
                }
                tokens.Enqueue(s.ToString());
            }
        }

        if (numberBuffer != "")
        {
            tokens.Enqueue(numberBuffer);
        }
        if (wordBuffer != "")
        {
            tokens.Enqueue(wordBuffer);
        }
        return tokens;
    }
}