using System.Text;

namespace ProblemsAlgoExpert.Strings
{
    public static class Run_LengthEncoding
    {
        // O(n) time | O(n) space where n is the length of the input string
        public static string RunLengthEncoding(string str)
        {
            // Write your code here.
            StringBuilder wordEncoded = new StringBuilder();
            char lastLetter = str[0];
            int countRepeat = 1;

            if (str.Length == 1)
            {
                wordEncoded.Append($"{1}{lastLetter}");
                return wordEncoded.ToString();
            }
            for (int idx = 1; idx < str.Length; idx++)
            {
                char actualLetter = str[idx];
                if (lastLetter == actualLetter)
                {
                    if (countRepeat == 9)
                    {
                        wordEncoded.Append($"{9}{lastLetter}");
                        countRepeat = 0;
                    }
                }
                else
                {
                    wordEncoded.Append($"{countRepeat}{lastLetter}");
                    countRepeat = 0;
                }

                lastLetter = actualLetter;
                countRepeat++;
            }

            wordEncoded.Append($"{countRepeat}{lastLetter}");
            return wordEncoded.ToString();
        }

        // O(n) time | O(n) space where n is the length of the input string
        public static string RunLengthEncodingSol2(string str)
        {
            StringBuilder wordEncoded = new StringBuilder();
            int currentRunLength = 1;

            for (int idx = 1; idx < str.Length; idx++)
            {
                char previousLetter = str[idx - 1];
                char actualLetter = str[idx];
                if ((actualLetter != previousLetter) || (currentRunLength == 9))
                {
                    wordEncoded.Append($"{currentRunLength}{previousLetter}");
                    currentRunLength = 0;
                }
                currentRunLength += 1;
            }

            wordEncoded.Append($"{currentRunLength}{str[str.Length - 1]}");
            return wordEncoded.ToString();
        }
    }
}
