using Xunit;
using System.Collections.Generic;
using Anagram.Objects;

namespace Anagram
{
  public class AnagramCheckerTest
  {
    [Fact]
    public void AnagramCheckerTest_OneWord_True()
    {
      AnagramChecker testAnagramChecker = new AnagramChecker("bread", "beard");
      Assert.Equal(true, testAnagramChecker.Check());
    }
  }
}
