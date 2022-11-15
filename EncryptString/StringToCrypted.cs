using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptString
{
    internal static class StringtoCrypted 
    {
        static string englishSentence = Console.ReadLine();
        static char[] englishChars = englishSentence.ToLower().ToCharArray();

        static char[] encryptionKey = {'$', '*', '%', '&', '>', '<', '!', ')', '(', '@', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
        'l', 'm', 'n', 'o'};
        static char[] returnEncrypt = new char[englishChars.Length];
        
             
        public static string EncryptionInstruction()
        {
            for (int i = 0; i < englishChars.Length; i++)
            {
                if (englishChars[i] == 'a')
                    returnEncrypt[i] = encryptionKey[0];
                else if (englishChars[i] == 'b')
                    returnEncrypt[i] = encryptionKey[1];
                else if (englishChars[i] == 'c')
                    returnEncrypt[i] = encryptionKey[2];
                else if (englishChars[i] == 'd')
                    returnEncrypt[i] = encryptionKey[3];
                else if (englishChars[i] == 'e')
                    returnEncrypt[i] = encryptionKey[4];
                else if (englishChars[i] == 'f')
                    returnEncrypt[i] = encryptionKey[5];
                else if (englishChars[i] == 'g')
                    returnEncrypt[i] = encryptionKey[6];
                else if (englishChars[i] == 'h')
                    returnEncrypt[i] = encryptionKey[7];
                else if (englishChars[i] == 'i')
                    returnEncrypt[i] = encryptionKey[8];
                else if (englishChars[i] == 'j')
                    returnEncrypt[i] = encryptionKey[9];
                else if (englishChars[i] == 'k')
                    returnEncrypt[i] = encryptionKey[10];
                else if (englishChars[i] == 'l')
                    returnEncrypt[i] = encryptionKey[11];
                else if (englishChars[i] == 'm')
                    returnEncrypt[i] = encryptionKey[12];
                else if (englishChars[i] == 'n')
                    returnEncrypt[i] = encryptionKey[13];
                else if (englishChars[i] == 'o')
                    returnEncrypt[i] = encryptionKey[14];
                else if (englishChars[i] == 'p')
                    returnEncrypt[i] = encryptionKey[15];
                else if (englishChars[i] == 'q')
                    returnEncrypt[i] = encryptionKey[16];
                else if (englishChars[i] == 'r')
                    returnEncrypt[i] = encryptionKey[17];
                else if (englishChars[i] == 's')
                    returnEncrypt[i] = encryptionKey[18];
                else if (englishChars[i] == 't')
                    returnEncrypt[i] = encryptionKey[19];
                else if (englishChars[i] == 'u')
                    returnEncrypt[i] = encryptionKey[20];
                else if (englishChars[i] == 'v')
                    returnEncrypt[i] = encryptionKey[21];
                else if (englishChars[i] == 'w')
                    returnEncrypt[i] = encryptionKey[22];
                else if (englishChars[i] == 'x')
                    returnEncrypt[i] = encryptionKey[23];
                else if (englishChars[i] == 'y')
                    returnEncrypt[i] = encryptionKey[24];
                else if (englishChars[i] == 'z')
                    returnEncrypt[i] = encryptionKey[25];

            }
            string encryptedString = new string(returnEncrypt);
            return encryptedString;
        }
    }
}
