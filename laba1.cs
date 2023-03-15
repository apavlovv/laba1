using System.Collections.Generic;
using System;

namespace laba
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, string> Words = new Dictionary<int, string>();
                Console.WriteLine("Введiть текст: ");
                string text = Console.ReadLine();

                string[] arrayOfWordsFromText = text.Split(' ');

                int index = 0;

                while (index < arrayOfWordsFromText.Length)
                {
                    Words.Add(index, arrayOfWordsFromText[index]);
                    index++;
                }
                int el, element, position;
                while (true)
                {
                    Console.WriteLine($"\nНомер слова в текстi = {arrayOfWordsFromText.Length}\n");

                    foreach (KeyValuePair<int, string> i in Words)
                    {
                        Console.WriteLine(i.Key + 1 + " " + i.Value);
                    }
                    Console.Write("\nНомер елемента: ");
                    if (int.TryParse(Console.ReadLine(), out el) && el >= 0 && el <= arrayOfWordsFromText.Length)
                    {
                        element = el - 1;

                        Console.Write("\nВведiть напрямок (</>): ");
                        string direction = Console.ReadLine();

                        if (direction == ">")
                        {
                            for (index = element; index < arrayOfWordsFromText.Length; index++)
                            {
                                Console.WriteLine(arrayOfWordsFromText[index]);
                            }
                        }

                        if (direction == "<")
                        {
                            for (index = element; index >= 0; index--)
                            {
                                Console.WriteLine(arrayOfWordsFromText[index]);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Невiрне значення");
                    }
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
        }
    }
}
