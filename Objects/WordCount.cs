using System.Collections.Generic;
using System;
using System.Linq;

namespace WordCountNS.Objects
{
  public class WordCounter
    {

      private string _singleWord;
      private string _phrase;

        public WordCounter (string singleWord, string phrase)
        {
          _singleWord = singleWord;
          _phrase = phrase;
        }

        public int RepeatCounter ()
        {
          int times = 0;
          string LowerPhrase = _phrase.ToLower();
          string LowerWord = _singleWord.ToLower();
          List<string> phraseSplit = LowerPhrase.Split(' ').ToList();
          for(var i = 0; i < phraseSplit.Count; i++)
          {
            if (LowerWord == phraseSplit[i])
            {
              times +=1;
            }
          }

          return times;
        }
   }
}
