using NUnit.Framework;

namespace Wordle.Test;

public class WordTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldReturnAll2sWhenEqual()
    {
        var guess = new Word("world");
        var actual = new Word("world");
        Assert.AreEqual("22222", guess.CompareTo(actual));
    }

    [Test]
    public void ShouldReturnAll0sWhenNoSimilarLetters(){
        var guess = new Word("world");
        var actual = new Word("might");
        Assert.AreEqual("00000", guess.CompareTo(actual));
    }
}