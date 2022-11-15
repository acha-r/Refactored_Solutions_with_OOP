using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishToPigLatin
{
    internal class PigLatin
    {
        public PigLatin()
        {
            TranslateToPigLatin();
        }
        public static void TranslateToPigLatin()
        {
            Console.WriteLine("Say anything ");
            string sentenceInEnglish = Console.ReadLine();
            string[] splitSentence = sentenceInEnglish.ToLower().Split(' ');
            List<string> splitEnglishSentence = new List<string>();

            foreach (string word in splitSentence)
            {

                string firstLetter = word[0] + "ay";
                string restOfWord = word.Substring(1);

                splitEnglishSentence.Add(restOfWord + firstLetter);
            }


            Console.WriteLine(String.Join(" ", splitEnglishSentence));

        }
    }
}
