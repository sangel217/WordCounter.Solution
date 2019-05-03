namespace WordCounter.Models
{
  public class Counter
  {
    private string _word;
    private string _sentence;

    public Counter (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetCounterWord()
    {
      return _word;
    }

    public string GetCounterSentence()
    {
      return _sentence;
    }

    public string MakeLowerCaseWord()
    {
      return _word.ToLower();
    }

    public string MakeLowerCaseSentence()
    {
      return _sentence.ToLower();
    }

    public string[] MakeWordArray()
    {
      return _sentence.Split(' ');
    }

    public bool CompareWordAndArray(string word)
    {
      // string[] splitArray = _sentence.Split(' ');
      // foreach(string splitWord in splitArray)
      // {
      //   if(_word == splitWord)
      //   {
      //     return 1;
      //   }
      // }
    }
  }
}
