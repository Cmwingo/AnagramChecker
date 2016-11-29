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
      string testWord = "bread";
      string testWordList = "beard";
      AnagramChecker testAnagramChecker = new AnagramChecker(testWord, testWordList);
      List<string> results = testAnagramChecker.Check();
      string sortedTestWord = AnagramChecker.SortWord(testWord);
      string sortedPossibleAnagram = AnagramChecker.SortWord(results[0]);
      Assert.Equal(true, sortedPossibleAnagram == sortedTestWord);
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
        string sortedPossibleAnagram = AnagramChecker.SortWord(possibleAnagram);
        if(sortedPossibleAnagram != sortedTestWord)
        {
          goodData = false;
        }
      }
      Assert.Equal(true, goodData);
    }

    [Fact]
    public void AnagramCheckerTest_WillReturnNonAnagrams_False()
    {
      bool goodData = true;
      string testWord = "bread";
      string testWordList = "beard,bared,kite,flyer";
      AnagramChecker testAnagramChecker = new AnagramChecker(testWord, testWordList);
      List<string> results = testAnagramChecker.Check();
      string sortedTestWord = AnagramChecker.SortWord(testWord);
      foreach(string possibleAnagram in results)
      {
        Console.WriteLine(possibleAnagram);
        string sortedPossibleAnagram = AnagramChecker.SortWord(possibleAnagram);
        if(sortedPossibleAnagram != sortedTestWord)
        {
          goodData = false;
        }
      }
      Assert.Equal(true, goodData);
    }
  }
}
