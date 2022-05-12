namespace Wordle;

public class Word
{
    private string word;
    public Word(string word){
        this.word = word.ToLower();
    }

    public string CompareTo(Word other)
    {
        var result = "";
        for (var i = 0; i < this.word.Length; i++)
        {
            result += CheckLetter(other, i);
        }
        return result; 
    }

    private string CheckLetter(Word other, int i)
    {
        if (this.word[i] == other.word[i]) return "2";
        else if (other.word.Contains(this.word[i])) return "1";
        return "0";
    }
}