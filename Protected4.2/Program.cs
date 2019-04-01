using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstTask();
            SecondTask();
        }

        static void FirstTask()
        {
            string inputText;
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' };

            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                IsEmpty(MyFile);
                inputText = MyFile.ReadToEnd().Replace('\n', ' ');
            }

            string[] words = inputText.Split(separator);

            foreach (var word in words)
            {
                if(word != words.Last())
                {
                    Console.WriteLine(word);
                }
            }
        }

        // Заменяем все буквы в массиве на символ *, если длинна строки больше 20.
        static void SecondTask()
        {
            string inputText = Console.ReadLine();
            
            if(inputText.Length > 20)
            {
                string newString = new string(inputText.Select(c => char.IsLetter(c) ? '*' : c).ToArray());
                Console.WriteLine(newString);
            }
        }

        static void IsEmpty(StreamReader someFile)
        {
            someFile.BaseStream.Position = 0;
            if (someFile.ReadToEnd() == "")
            {
                Console.WriteLine("File is empty!");
                Environment.Exit(0);
            }
            someFile.BaseStream.Position = 0;
        }
    }
}
