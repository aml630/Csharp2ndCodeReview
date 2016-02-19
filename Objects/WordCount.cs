using System.Collections.Generic;
using System;
using System.Linq;

namespace WordCountNS.Objects
{
  public class WordCounter
    {


        public WordCounter ()
        {

        }

        public static int RepeatCounter (string singleWord, string phrase)
        {
          string inputWord = singleWord;
          int times = 0;
          List<string> phraseSplit = phrase.Split(' ').ToList();
          for(var i = 0; i < phraseSplit.Count; i++)
          {
            if (inputWord == phraseSplit[i])
            {
              times +=1;
            }
          }

          return times;
        }



  }
}
