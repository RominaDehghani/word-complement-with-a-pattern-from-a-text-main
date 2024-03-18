using System;

namespace 2020510096_romina_dehghani_mohammadi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting text from the user.
            Console.WriteLine("please enter a text: ");
            string text = Console.ReadLine();
            text = text.ToLower();

            //Delete punctuations that should not be in the text, and placement distance instead.
            text = text.Replace("`", " ");
            text = text.Replace("~", " ");
            text = text.Replace("!", " ");
            text = text.Replace("@", " ");
            text = text.Replace("#", " ");
            text = text.Replace("$", " ");
            text = text.Replace("%", " ");
            text = text.Replace("^", " ");
            text = text.Replace("&", " ");
            text = text.Replace("*", " ");
            text = text.Replace("(", " ");
            text = text.Replace(")", " ");
            text = text.Replace("_", " ");
            text = text.Replace("-", " ");
            text = text.Replace("=", " ");
            text = text.Replace("+", " ");
            text = text.Replace("\\", " ");
            text = text.Replace("|", " ");
            text = text.Replace("\"", " ");
            text = text.Replace("}", " ");
            text = text.Replace("{", " ");
            text = text.Replace("]", " ");
            text = text.Replace("[", " ");
            text = text.Replace(";", " ");
            text = text.Replace(":", " ");
            text = text.Replace("'", " ");
            text = text.Replace("  ", " ");
            text = text.Replace("/", " ");
            text = text.Replace("?", " ");
            text = text.Replace(">", " ");
            text = text.Replace("<", " ");
            text = text.Replace("ş", "s");
            text = text.Replace("ı", "i");
            text = text.Replace("ğ", "g");
            text = text.Replace("ü", "u");
            text = text.Replace("ç", "c");
            text = text.Replace("ö", "o");

            //Separating text's words and convert them to arrays.
            string[] words = null;
            words = text.Split(' ');

            Console.WriteLine("Please enter a pattern with a word in the text: ");
            string pattern = Console.ReadLine();

            //Controlling when the user enters punctuations except (*) and (-).
            while (pattern.Contains("*") && pattern.Contains("-"))
            {
                Console.WriteLine("Pattern can not contain both punctuations (-) and (*).");
                pattern = Console.ReadLine();
            }

            //Controlling when the user does not enter (*) or (-).
            while (!(pattern.Contains("*") || pattern.Contains("-")))
            {
                Console.WriteLine("Pattern must contain (-) or (*). ");
                pattern = Console.ReadLine();
            }

            //Delete punctuations that should not be in the pattern, and placement distance instead.
            pattern = pattern.Replace("`", " ");
            pattern = pattern.Replace("~", " ");
            pattern = pattern.Replace("!", " ");
            pattern = pattern.Replace("@", " ");
            pattern = pattern.Replace("#", " ");
            pattern = pattern.Replace("$", " ");
            pattern = pattern.Replace("%", " ");
            pattern = pattern.Replace("^", " ");
            pattern = pattern.Replace("&", " ");
            pattern = pattern.Replace(".", " ");
            pattern = pattern.Replace("(", " ");
            pattern = pattern.Replace(")", " ");
            pattern = pattern.Replace("_", " ");
            pattern = pattern.Replace(",", " ");
            pattern = pattern.Replace("=", " ");
            pattern = pattern.Replace("+", " ");
            pattern = pattern.Replace("\\", " ");
            pattern = pattern.Replace("|", " ");
            pattern = pattern.Replace("\"", " ");
            pattern = pattern.Replace("}", " ");
            pattern = pattern.Replace("{", " ");
            pattern = pattern.Replace("]", " ");
            pattern = pattern.Replace("[", " ");
            pattern = pattern.Replace(";", " ");
            pattern = pattern.Replace(":", " ");
            pattern = pattern.Replace("'", " ");
            pattern = pattern.Replace("  ", " ");
            pattern = pattern.Replace("/", " ");
            pattern = pattern.Replace("?", " ");
            pattern = pattern.Replace(">", " ");
            pattern = pattern.Replace("<", " ");
            pattern = pattern.Replace("ş", "s");
            pattern = pattern.Replace("ı", "i");
            pattern = pattern.Replace("ğ", "g");
            pattern = pattern.Replace("ü", "u");
            pattern = pattern.Replace("ç", "c");
            pattern = pattern.Replace("ö", "o");

            
            //Putting words instead of pattern, and removing duplicate words.
            if (pattern.Contains('-'))
            {
                int markIndex = pattern.IndexOf("-");     //We can check where the mark is with this function. With the help of the IndexOf function, we can easily make substrings to find what we are looking for.
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            words[j] = "";
                        }

                    }
                }

                /* Instead of only checking for the words with the same length, we have to check the words with the same pattern.
                 * To accomplish this; after checking if the word is the same length as the pattern, we have to check the location where the mark is placed.
                 * The if clause that I put inside the for loop doesn't solve the full problem but it will help us a hold of the main idea.
                 */

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length == pattern.Length)
                    {
                        if (words[i].Contains(pattern.Substring(markIndex + 1)))
                        {
                            Console.WriteLine(words[i]);
                        }
                        //Console.WriteLine(words[i]);
                    }
                }
            }


            if (pattern.Contains('*'))
            {
                int markIndex = pattern.IndexOf("*");
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            words[j] = "";
                        }

                    }
                }
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length >= pattern.Length)
                    {
                        if (words[i].Contains(pattern.Substring(markIndex + 1)))
                        {
                            Console.WriteLine(words[i]);
                        }
                        //Console.WriteLine(words[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }  
}        