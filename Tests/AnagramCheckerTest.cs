using Xunit;
using System.Collections.Generic;
using Anagram.Objects;
using System;

namespace Anagram
{
  public class AnagramCheckerTest
  {
    // [Fact]
    // public void AnagramCheckerTest_OneWord_True()
    // {
    //   AnagramChecker testAnagramChecker = new AnagramChecker("bread", "beard");
    //   Assert.Equal(true, testAnagramChecker.Check());
    // }

    [Fact]
    public void AnagramCheckerTest_MultipleWords_True()
    {
      bool goodData = true;
      string testWord = "bread";
      string testWordList = "beard,bared";
      AnagramChecker testAnagramChecker = new AnagramChecker(testWord, testWordList);
      List<string> results = testAnagramChecker.Check();
      string sortedTestWord = AnagramChecker.SortWord(testWord);
      foreach(string possibleAnagram in results)
      {
        Console.WriteLine(possibleAnagram);
        if(possibleAnagram != sortedTestWord)
        {
          goodData = false;
        }
      }
      Assert.Equal(true, goodData);
    }
  }
}
