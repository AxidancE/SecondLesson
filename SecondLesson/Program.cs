using System;
//using System.Linq.Expressions;
//using System.Collections.Generic;
using System.IO;

namespace secondLesson
{
    class Program
    {
        static void Main()
        {
            //string word = "Hello";
            //word += " world!";

            ////Console.WriteLine(word.Length);
            ////word = String.Concat(word, " New words.");



            //Console.WriteLine(String.Compare(word, "Hello world!"));
            //// 0 - equals
            //// 1 - not equals
            //// -1 - partially equals.

            //string people = "Alex,Bob,John";

            //string[] names = people.Split(',');

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //people = String.Join(", ", names);
            //Console.WriteLine(people);

            ////Console.WriteLine(word.Trim());
            //Console.WriteLine(word.Substring(0, word.Length - 1));

            System.Console.Write("Enter text:");
            string text = Console.ReadLine();

            using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                stream.Write(array, 0, array.Length);
            }

            using (FileStream stream1 = File.OpenRead("info.txt"))
            {
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);
            }
        }
    }
}