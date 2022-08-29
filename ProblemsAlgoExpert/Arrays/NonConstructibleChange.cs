namespace ProblemsAlgoExpert.Arrays
{
    public static class NonConstructibleChange
    {
        // O(n log n) time | 0(1) space - where n is the number of coins 
        public static int NonConstructibleChangeSol1(int[] coins)
        {
            Array.Sort(coins);

            int currentChangeCreated = 0;
            foreach (var coin in coins)
            {
                if (coin > currentChangeCreated + 1)
                {
                    return currentChangeCreated + 1;
                }

                currentChangeCreated += coin;
            }

            return currentChangeCreated + 1;
        }
    }
}
