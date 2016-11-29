using Xunit;
using System.Collections.Generic;
using Anagram.Objects;
using System;

namespace Anagram
{
  public class AnagramCheckerTest
  {
    [Fact]
    public void AnagramCheckerTest_OneWord_True()
    {
      // bool goodData = true;
      string testWord = "bread";
      string testWordList = "beard";
      AnagramChecker testAnagramChecker = new AnagramChecker(testWord, testWordList);
      List<string> results = testAnagramChecker.Check();
      string sortedTestWord = AnagramChecker.SortWord(testWord);
      Assert.Equal(true, results[0] == sortedTestWord);
    }

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
