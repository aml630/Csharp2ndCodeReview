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

  }
}
