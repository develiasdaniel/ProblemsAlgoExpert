using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAlgoExpert.Strings
{
    public static class CaesarCypherEncryptor
    {
        #region Solution1
        // O(n * k) time | O(n) space
        public static string CaesarCypherEncryptorSolution1(string str, int key)
        {
            int newkey = key % 26;
            StringBuilder newWord = new StringBuilder();
            foreach (char letter in str)
            {
                char newLetter = letter;
                for (int number = 1; number <= newkey; number++)
                {
                    if (newLetter == 'z')
                    {
                        newLetter = 'a';
                    }
                    else
                    {
                        newLetter++;
                    }
                }
                newWord.Append(newLetter);
            }
            return newWord.ToString();
        }
        #endregion

        #region Solution2 y 3
        // O(n) time | O(n) space
        private const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";       
        public static string CaesarCypherEncryptorSolution2(string str, int key)
        {
            int newKey = key % 26;
            StringBuilder newWord = new StringBuilder();
            for (int idx = 0; idx < str.Length; idx++)
            {
                char letter = str[idx];
                int newPositionLetter = ALPHABET.IndexOf(letter) + newKey;
                char newLetter = ALPHABET[newPositionLetter % 26];
                newWord.Append(newLetter);
            }
            return newWord.ToString();
        }
        public static string CaesarCypherEncryptorSolution3(string str, int key)
        {
            int newKey = key % 26;
            StringBuilder newWord = new StringBuilder();
            for (int idx = 0; idx < str.Length; idx++)
            {
                char letter = str[idx];
                int newPositionLetter = ALPHABET.IndexOf(letter) + newKey;
                char newLetter = newPositionLetter <= 25
                    ? ALPHABET[newPositionLetter]
                    : ALPHABET[newPositionLetter % 26];
                newWord.Append(newLetter);
            }
            return newWord.ToString();
        }
        #endregion

        #region solution4
        // O(n) time | O(n) space
        public static string CaesarCypherEncryptorSolution4(string str, int key)
        {
            char[] newLetters = new char[str.Length];
            int newKey = key % 26;
            for (int idx = 0; idx < str.Length; idx++)
            {
                newLetters[idx] = getNewLetter(str[idx], newKey); 
            }
            return new String(newLetters);
        }

        private static char getNewLetter(char letter, int key)
        {
            int newLetterCode = letter + key;
            return  newLetterCode <= 122
                ?  (char)newLetterCode
                : (char)(96 + (newLetterCode % 122));
        }
        #endregion
    }
}
