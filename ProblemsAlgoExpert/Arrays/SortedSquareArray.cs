using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAlgoExpert.Arrays
{
    public static class SortedSquareArray
    {
        public static int[] SortedSquaredArraySolutionOne(int[] array)
        {
            // Write your code here.
            var squares = new int[array.Length];
            for (var idx = 0; idx < array.Length; idx++)
            {
                var number = array[idx];
                squares[idx] = number * number;
            }
            Array.Sort(squares);
            return squares;
        }

        public static int[] SortedSquaredArraySolutionTwo(int[] array)
        {
            // Write your code here.
            var squares = array.Select(num => num * num).ToArray();
            return squares.OrderBy(num => num).ToArray();
        }

        public static int[] SortedSquaredArraySolutionThree(int[] array)
        {
            // Write your code here.
            var squares = new int[array.Length];
            var smallIdx = 0;
            var largerIdx = array.Length - 1;
            for (var idx = array.Length - 1; idx >= 0; idx--)
            {
                var smallValue = array[smallIdx];
                var largerValue = array[largerIdx];
                if (Math.Abs(smallValue) > Math.Abs(largerValue))
                {
                    squares[idx] = smallValue * smallValue;
                    smallIdx++;
                    continue;
                }

                squares[idx] = largerValue * largerValue;
                largerIdx--;
            }
            return squares;
        }
    }
}
