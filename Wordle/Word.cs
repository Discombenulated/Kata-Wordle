namespace Wordle;

public class Word
{
    private string word;
    public Word(string word){
        this.word = word.ToLower();
    }

    public string CompareTo(Word other)
    {
        if (this.word == other.word) return "22222";
        return "00000";
    }
}