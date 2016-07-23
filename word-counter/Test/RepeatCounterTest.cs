using System.Collections.Generic;
using Xunit;
using System;

namespace WordCounter.Objects
{
  public class RepeatCounterTest : IDisposable
  {
    public void Dispose()
    {
      RepeatCounter.DeleteAll();
    }

      [Fact]
      public void Test1_RepeatCounterGetA_false()
      {

        RepeatCounter newRepeatCounter = new RepeatCounter("b");
        string testCounter = newRepeatCounter.GetWord();
        Assert.Equal("a", testCounter);
    }

  }

}
