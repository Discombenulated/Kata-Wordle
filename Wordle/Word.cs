namespace Wordle;

public class Word
{
    private const string INCORRECT_LETTER = "0";
    private const string CORRECT_LETTER_WRONG_INDEX = "1";
    private const string CORRECT_LETTER_CORRECT_INDEX = "2";

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
        if (this.word[i].Equals(other.word[i])) return CORRECT_LETTER_CORRECT_INDEX;
        else if (other.word.Contains(this.word[i])) return CORRECT_LETTER_WRONG_INDEX;
        return INCORRECT_LETTER;
    }
}