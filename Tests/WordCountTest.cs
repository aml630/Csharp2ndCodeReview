using Xunit;
using WordCountNS.Objects;
using System.Collections.Generic;
using System;

namespace WordCountTestNS
{
  public class WordCount
  {
    [Fact]
    public void Check_Double_Word()
    {
      Assert.Equal(2, WordCounter.RepeatCounter("hey", "hey hey"));
    }
    [Fact]
    public void Check_Single_Word()
    {
      Assert.Equal(1, WordCounter.RepeatCounter("hey", "hey"));
    }
  }
}
