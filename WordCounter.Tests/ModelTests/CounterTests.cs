using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTest
  {

    [TestMethod]
    public void CounterConstructor_CreatesOfConstructor_Counter()
    {
      Counter newObject = new Counter("test", "test");
      Assert.AreEqual(typeof(Counter), newObject.GetType());
    }

    [TestMethod]
    public void GetCounterObeject_ReturnsWord_String()
    {
      string inputWord = "hello";
      string sentence = "hello my name is sarah";
      Counter newObject = new Counter(inputWord, sentence);
      string result = newObject.GetCounterWord();
      Assert.AreEqual(inputWord, result);
    }

    [TestMethod]
    public void GetCounterSentence_ReturnsSentence_String()
    {
      string sentence = "hello my name is sarah";
      string inputWord = "hello";
      Counter newObject = new Counter(inputWord, sentence);
      string result = newObject.GetCounterSentence();
      Assert.AreEqual(sentence, result);
    }

    [TestMethod]
    public void  MakeLowerCaseWord_ReturnsLowerCase_String()
    {
      string inputWord = "HELLO";
      string sentence = "HEllo My Name iS Sarah";
      Counter newObject = new Counter(inputWord, sentence);
      string result = newObject.MakeLowerCaseWord();
      string expected = "hello";
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void  MakeLowerCaseSentence_ReturnsLowerCase_String()
    {
      string inputWord = "HELLO";
      string sentence = "HEllo My Name iS Sarah";
      Counter newObject = new Counter(inputWord, sentence);
      string result = newObject.MakeLowerCaseSentence();
      string expected = "hello my name is sarah";
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void MakeWordArray_ReturnWordArrayOfSentence_StringArray()
    {
      string inputWord = "hello";
      string sentence = "hello my name is sarah";
      Counter newObject = new Counter(inputWord, sentence);
      string[] myArray = newObject.MakeWordArray();
      string[] expected = {"hello", "my", "name", "is", "sarah"};
      CollectionAssert.AreEqual(expected, myArray);
    }

    [TestMethod]
    public void CompareWordAndArray_ReturnIntegers_Integer()
    {
      string inputWord = "hello";
      string sentence = "hello my name is sarah";
      Counter newObject = new Counter(inputWord, sentence);
      Assert.AreEqual(1, newObject.CompareWordAndArray());

    }
  }
}
