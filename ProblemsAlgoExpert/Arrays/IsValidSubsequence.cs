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
			var lastIndex = 0;
			foreach (var num in sequence)
			{
				var index = array.IndexOf(num);
				if (index == -1)
				{
					return false;
				}

				if (lastIndex > index)
				{
					return false;
				}
				lastIndex = index;
			}
			return true;
		}
	}
}
