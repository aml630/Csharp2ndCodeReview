using Xunit;
using RepeatCounterNS.Objects;
using System.Collections.Generic;
using System;

namespace WordCountTestNS
{
  public class WordCount
  {
    [Fact]
    public void Check_Single_Character()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("a", "a"));
    }

    [Fact]
    public void Check_Single_Character_Against_Longer_Phrase()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("a", "a cat"));
    }

    [Fact]
    public void Check_Word_Against_Single_Character_Phrase()
    {
      Assert.Equal(0, RepeatCounter.CountRepeats("cat", "a"));
    }

    [Fact]
    public void Check_Word_Against_Single_Word_Phrase()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("cat", "cat"));
    }

    [Fact]
    public void Check_Word_Capitalized_Against_Single_Word_Phrase()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("Cat", "cat"));
    }

    [Fact]
    public void Check_Word_Capitalized_Against_Phrase_With_Many_Capitals()
    {

      Assert.Equal(3, RepeatCounter.CountRepeats("Cat", "cat Cat CAT"));
    }
  }
}
