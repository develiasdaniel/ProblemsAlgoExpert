namespace ProblemsAlgoExpert.Strings
{
    public static class GenerateDocument
    {
        // O(n * (m + m)) time | O(1) space
        // where n is document size and m characters size
        public static bool GenerateDocumentSolution(string characters, string document)
        {
            // Write your code here.
            for (int idx = 0; idx < document.Length; idx++)
            {
                char letterDocument = document[idx];
                int indexCharacter = characters.IndexOf(letterDocument);
                if (indexCharacter == -1)
                {
                    return false;
                }

                characters = characters.Remove(indexCharacter, 1);
            }
            return true;
        }

        // O(n + m) time | O (c) space 
        // where n is characters size and n document size 
        // and c is the size of unique characters in characters string
        public static bool GenerateDocumentSolution2(string characters, string document)
        {
            // Write your code here.
            var characterCounts = new Dictionary<char, int>();
            foreach (var letter in characters)
            {
                characterCounts[letter] =
                    characterCounts.GetValueOrDefault(letter, 0) + 1;
            }

            foreach (var letter in document)
            {
                if (!characterCounts.ContainsKey(letter) || characterCounts[letter] == 0)
                {
                    return false;
                }

                characterCounts[letter] = characterCounts[letter] - 1;
            }
            return true;
        }


        // O(n + m) time | O (c) space 
        // where n is characters size and n document size 
        // and c is the size of unique characters in characters string
        public static bool GenerateDocumentSolution3(string characters, string document)
        {
            // Write your code here.
            var alreadyCounted = new HashSet<char>();

            foreach (var letter in document)
            {
                if (alreadyCounted.Contains(letter))
                {
                    continue;
                }

                int documentFrequency = countcharFrequency(letter, document);
                int characterfrequency = countcharFrequency(letter, characters);
                if(documentFrequency > characterfrequency)
                {
                    return false;
                }
                alreadyCounted.Add(letter);
            }
            return true;
        }

        private static int countcharFrequency(char character, string target)
        {
            int frequency = 0;
            foreach (var letter in target)
            {
                if(letter == character)
                {
                    frequency++;
                }
            }

            return frequency;
        }
    }
}
