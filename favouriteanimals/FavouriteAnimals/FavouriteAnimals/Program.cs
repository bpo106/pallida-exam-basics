using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FavouriteAnimals
{
    public class FavouriteAnimals
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length > 0)
            {
                Save(input);
            }
            else
            {
                Print();
            }
            Console.ReadLine();
        }

        public static void Save (string input)
        {
            List<string> list = input.Split(' ').ToList();
            using (StreamWriter fileOut = File.AppendText("favourites.txt"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    fileOut.WriteLine(list[i]);
                }
            }
        }

        public static void Print ()
        {
            using (StreamReader fileIn = new StreamReader("favourites.txt"))
            {
                string line;
                Console.Write("C# FavouriteAnimals");
                while ((line = fileIn.ReadLine()) != null)
                {
                    Console.Write(" " + line);
                }
            }
        }
    }
}