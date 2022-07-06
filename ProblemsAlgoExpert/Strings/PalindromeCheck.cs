namespace ProblemsAlgoExpert.Strings
{
    public class PalindromeCheck
    {
        // O(n) time | O(1) space
        public static bool IsPalindrome(string str)
        {
            // Write your code here.
            int indexLeft = 0;
            int indexRight = str.Length - 1;

            while (indexLeft <= indexRight)
            {
                var letterLeft = str[indexLeft];
                var letterRight = str[indexRight];
                if (letterLeft == letterRight)
                {
                    indexLeft++;
                    indexRight--;
                }
                else
                {
                    return false; // not is a palindrome    
                }
            }
            return true;
        }

        // O(n) time | O(n) space
        public static bool IsPalindrome2(string str)
        {
            // Write your code here.
            var reverseLetters = new List<char>();
            for (int idx = str.Length - 1; idx >= 0; idx--)
            {
                reverseLetters.Add(str[idx]);
            }
            string reverseWord = string.Join("", reverseLetters);
            return str == reverseWord;
        }

        // O(n) time | O(n) space
        public static bool IsPalindrome3(string str)
        {
            // Write your code here.
            char[] wordRightArray = str.ToCharArray();
            Array.Reverse(wordRightArray);
            string reverseString = new String(wordRightArray);
            return str == reverseString;
        }

        // O(n) time | O(n) space
        public static bool IsPalindrome4(string str)
        {
            // Write your code here.
            var isEven = str.Length % 2 == 0;
            int half = str.Length / 2;
            string wordLeft;
            if (isEven)
            {
                wordLeft = str.Substring(0, half);
            }
            else
            {
                wordLeft = str.Substring(0, half + 1);
            }

            char[] wordRightArray = str.Substring(half).ToCharArray();
            Array.Reverse(wordRightArray);
            string wordRight = new String(wordRightArray);
            return wordLeft == wordRight;
        }

    }
}
