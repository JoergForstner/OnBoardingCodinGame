using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
  static void Main(string[] args)
  {
    int L = int.Parse(Console.ReadLine());
    int H = int.Parse(Console.ReadLine());
    string T = Console.ReadLine();
    Dictionary<int, Dictionary<string, string>> letters = new Dictionary<int, Dictionary<string, string>>();
    Dictionary<int, string> PossibleLetters = new Dictionary<int, string>();
    Init(ref PossibleLetters);
    string answer = string.Empty;

    for (int i = 0; i < H; i++)
    {
      string ROW = Console.ReadLine();
      IEnumerable<string> Splittedrow = ChunksUpto(ROW, L);
      ReadInputRow(Splittedrow,i, PossibleLetters, ref letters);
    }

    for (int i = 0; i < H; i++)
    {
      for (int j = 0; j < T.Length; j++)
      {
        string letter = T.Substring(j, 1).ToUpper();
        int letterindex = -1;
        //Find index in letters
        foreach (var item in PossibleLetters)
        {
          if (item.Value.Equals(letter))
            letterindex = item.Key;
        }

        foreach (var item in letters)
        {
          if (item.Key == i)
          {
            Dictionary<string, string> lok = item.Value;
            foreach (var answerstring in lok)
            {
              if (answerstring.Key.Equals(letter))
                answer += answerstring.Value;
            }
          }
        }
      }
      Console.WriteLine(answer);
      answer = string.Empty;
    }
  }


  static IEnumerable<string> ChunksUpto(string str, int maxChunkSize)
  {
    for (int i = 0; i < str.Length; i += maxChunkSize)
      yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
  }

  static void ReadInputRow(IEnumerable<string> text, int index, Dictionary<int, string> PossibleLetters, ref Dictionary<int, Dictionary<string, string>> letters)
  {
    int cnt = 0;
    Dictionary<string, string> letterrowstring = new Dictionary<string, string>();
    foreach (string i in text)
    {
      letterrowstring.Add(PossibleLetters[cnt], i.ToString());
      cnt++;
    }
    letters.Add(index, letterrowstring);
  }

  static void Init(ref Dictionary<int, string> PossibleLetters)
  {
    PossibleLetters.Add(0, "A");
    PossibleLetters.Add(1, "B");
    PossibleLetters.Add(2, "C");
    PossibleLetters.Add(3, "D");
    PossibleLetters.Add(4, "E");
    PossibleLetters.Add(5, "F");
    PossibleLetters.Add(6, "G");
    PossibleLetters.Add(7, "H");
    PossibleLetters.Add(8, "I");
    PossibleLetters.Add(9, "J");
    PossibleLetters.Add(10, "K");
    PossibleLetters.Add(11, "L");
    PossibleLetters.Add(12, "M");
    PossibleLetters.Add(13, "N");
    PossibleLetters.Add(14, "O");
    PossibleLetters.Add(15, "P");
    PossibleLetters.Add(16, "Q");
    PossibleLetters.Add(17, "R");
    PossibleLetters.Add(18, "S");
    PossibleLetters.Add(19, "T");
    PossibleLetters.Add(20, "U");
    PossibleLetters.Add(21, "V");
    PossibleLetters.Add(22, "W");
    PossibleLetters.Add(23, "X");
    PossibleLetters.Add(24, "Y");
    PossibleLetters.Add(25, "Z");
    PossibleLetters.Add(26, "?");
  }

}
