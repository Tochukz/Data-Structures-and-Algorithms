using System.Text;

public class Reading
{
    public string makeSentence(string[] words)
    {
        StringBuilder builder = new StringBuilder();
        foreach (string word in words) {
            builder.Append(word);
        }
        return builder.ToString();
    }
}

Reading reading = new Reading();
string sentence = reading.makeSentence(new string[] {"Chucks ", "is ", "Amazone ", "Enginneer!"});
WriteLine(sentence);