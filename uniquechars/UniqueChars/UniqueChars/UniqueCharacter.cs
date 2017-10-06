using System;
using System.Collections.Generic;

namespace UniqueChars
{
    public class UniqueCharacter
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (UniqueCharacters(word).Count == 0)
            {
                Console.WriteLine("No unique characters");
            }
            else
            {
                Console.WriteLine("\"{0}\"", String.Join("\", \"", UniqueCharacters(word)));
            }
            Console.ReadLine();
        }

        public static List<string> UniqueCharacters (string word)
        {
            var list = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                list.Add(word.ToCharArray()[i].ToString().ToLower());
            }

            for (int i = 0; i < list.Count - 1;)
            {
                int count = list.Count;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
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