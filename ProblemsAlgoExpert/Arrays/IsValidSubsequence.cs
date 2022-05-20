using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAlgoExpert.Arrays
{
    public class IsValidSubsequence
    {
		public static bool IsValidSubsequenceSolution1(List<int> array, List<int> sequence)
		{
			// Write your code here.
			int lastIndex = -1;
			foreach (var num in sequence)
			{
				int currentIndex = array.IndexOf(num);
				if (currentIndex == -1)
				{
					return false;
				}

				if (currentIndex >= lastIndex)
				{
					lastIndex = currentIndex;
					array.RemoveAt(lastIndex);
					continue;
				}
				return false;
			}
			return true;
		}

		public static bool IsValidSubsequenceSolution2(List<int> array, List<int> sequence)
		{
			// Write your code here.
			int seqIdx = 0;
			foreach (var val in array)
			{
				if (seqIdx == sequence.Count)
				{
					break;
				}

				if (sequence[seqIdx] == val)
				{
					seqIdx++;
				}
			}
			return seqIdx == sequence.Count;
		}


	}
}
