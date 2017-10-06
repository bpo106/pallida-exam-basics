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
                Save(input, Read());
            }
            else
            {
                Print(Read());
            }
            Console.ReadLine();
        }

        public static List<string> Read ()
        {
            List<string> animalList = new List<string>();
            using (StreamReader fileIn = new StreamReader("favourites.txt"))
            {
                string line;
                while ((line = fileIn.ReadLine()) != null)
                {
                    animalList.Add(line);
                }
            }
            return animalList;
        }

        public static void Save (string input, List<string> animalList)
        {
            List<string> list = input.Split(' ').ToList();
            using (StreamWriter fileOut = File.AppendText("favourites.txt"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    bool isAlreadyIn = false;
                    for (int j = 0; j < animalList.Count; j++)
                    {
                        if (list[i] == animalList[j])
                        {
                            isAlreadyIn = true;
                            Console.WriteLine("{0} is already in the list", list[i]);
                        }
                    }
                    if (!isAlreadyIn)
                    {
                        fileOut.WriteLine(list[i]);
                    }
                }
            }
        }

        public static void Print (List<string> animalList)
        {
            Console.Write("C# FavouriteAnimals");
            for (int i = 0; i < animalList.Count; i++)
            {
                if (animalList[i] != "")
                {
                    Console.Write(" {0}", animalList[i]);
                }
            }
            
             
        }
    }
}