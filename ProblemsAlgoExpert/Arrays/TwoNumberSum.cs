using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAlgoExpert.Arrays
{
    public static class TwoNumberSum
    {
		public static int[] TwoNumberSumSolution1(int[] array, int targetSum)
		{
			// Write your code here.
			for (var x = 0; x < array.Length; x++)
			{
				var firstNum = array[x];
				for (var y = x + 1; y < array.Length; y++)
				{
					var secondNum = array[y];
					if (firstNum + secondNum == targetSum)
					{
						return new int[] { firstNum, secondNum };
					}
				}
			}
			return new int[0];
		}

		public static int[] TwoNumberSumSolution2(int[] array, int targetSum)
		{
			// Write your code here.
			HashSet<int> nums = new HashSet<int>();
            foreach (var num in array)
            {
				int potentialMatch = targetSum - num;
				if(nums.Contains(potentialMatch))
                {
					return new int[] { potentialMatch, num };
				}
                else
                {
					nums.Add(num);
                }
			}
			return new int[0];
		}
	}
}
