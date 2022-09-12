namespace ProblemsAlgoExpert.Arrays
{
    using System;
    using System.Collections.Generic;

    public static class ThreeNumberSum
    {
        // O(n ^ 3) time | O(n) space where n is array size 
        public static List<int[]> ThreeNumberSumSol1(int[] array, int targetSum)
        {
            // Write your code here.
            var results = new List<int[]>();
            for (int idx = 0; idx < array.Length - 2; idx++)
            {
                int numberOne = array[idx];
                for (int idxNumberTwo = idx + 1; idxNumberTwo < array.Length - 1; idxNumberTwo++)
                {
                    int numberTwo = array[idxNumberTwo];
                    for (int idxNumTree = idxNumberTwo + 1; idxNumTree < array.Length; idxNumTree++)
                    {
                        int numberTree = array[idxNumTree];
                        int sum = numberOne + numberTwo + numberTree;
                        if (sum == targetSum)
                        {
                            var sumArray = new int[] { numberOne, numberTwo, numberTree };
                            Array.Sort(sumArray);
                            results.Add(sumArray);
                        }
                    }
                }
            }
            return results.OrderBy(x => x[0]).ThenBy(x => x[1]).ThenBy(x => x[2]).ToList();
        }

        // O(n ^ 2) time | O(n) space
        public static List<int[]> ThreeNumberSumSol2(int[] array, int targetSum)
        {
            // Write your code here.
            List<int[]> triplets = new List<int[]>();

            Array.Sort(array);
            for (int idx = 0; idx < array.Length - 2; idx++)
            {
                int leftIdx = idx + 1;
                int rightIdx = array.Length - 1;
                while (leftIdx < rightIdx)
                {
                    int currentSum = array[idx] + array[leftIdx] + array[rightIdx];
                    if (currentSum == targetSum)
                    {
                        triplets.Add(new int[] { array[idx], array[leftIdx], array[rightIdx] });
                        leftIdx++;
                        rightIdx--;
                    }
                    else if (currentSum < targetSum)
                    {
                        leftIdx++;
                    }
                    else
                    {
                        rightIdx--;
                    }
                }
            }
            return triplets;
        }
    }
}
