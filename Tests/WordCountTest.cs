using Xunit;
using WordCountNS.Objects;
using System.Collections.Generic;
using System;

namespace WordCountTestNS
{
  public class WordCount
  {
    [Fact]
    public void Check_Single_Character()
    {
      WordCounter test = new WordCounter("a", "a");
      Assert.Equal(1, test.RepeatCounter());
    }

    [Fact]
    public void Check_Single_Character_Against_Longer_Phrase()
    {
      WordCounter test = new WordCounter("a", "a cat");
      Assert.Equal(1, test.RepeatCounter());
    }

    [Fact]
    public void Check_Word_Against_Single_Character_Phrase()
    {
      WordCounter test = new WordCounter("cat", "a");
      Assert.Equal(0, test.RepeatCounter());
    }

    [Fact]
    public void Check_Word_Against_Single_Word_Phrase()
    {
      WordCounter test = new WordCounter("cat", "cat");
      Assert.Equal(1, test.RepeatCounter());
    }
    [Fact]
    public void Check_Word_Capitalized_Against_Single_Word_Phrase()
    {
      WordCounter test = new WordCounter("Cat", "cat");
      Assert.Equal(1, test.RepeatCounter());
    }
  }
}
