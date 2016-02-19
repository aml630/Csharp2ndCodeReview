using System.Collections.Generic;
using System;
using System.Linq;

namespace RepeatCounterNS.Objects
{
  public class RepeatCounter
    {



        public static int CountRepeats (string _singleWord, string _phrase)
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
