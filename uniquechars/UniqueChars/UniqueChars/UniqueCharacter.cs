using System;
using System.Collections.Generic;

namespace UniqueChars
{
    public class UniqueCharacter
    {
        public static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"
        }

        public List<string> UniqueCharacters (string word)
        {
            var list = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                list.Add(word.ToCharArray()[i].ToString());
            }

            for (int i = 0; i < list.Count;)
            {
                int count = list.Count;
                for (int j = i; j < list.Count; j++)
                {
                    if (list[i] == list[j] && j != i)
                    {
                        list.RemoveAt(j);
                    }
                }
                if (count > list.Count)
                {
                    list.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

            return list;
        }
    }
}