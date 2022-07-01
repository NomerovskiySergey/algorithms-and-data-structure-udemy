using System;
using NUnit.Framework;

namespace Algorithms.Tests
{
    [TestFixture]
    public class SortingTests
    {
       private int [][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new int[] { 1,10,2,9,3,8,4,7 };
            samples[1] = new int[] {1};
            samples[2] = new int[] { 2,8 };
            samples[3] = new int[] { 1,9, 0 };
            samples[4] = new int[] { 0,12,-4,14 };
            samples[5] = new int[] { 9,5,3,2,6 }; 
            samples[6] = new int[] { 2,3,4,7,1,0,-12,2,67 }; 
            samples[7] = new int[] { 1,4,3,5,2,7,5,9,7 };
            samples[8] = new int[] { 9,2,1,-12,-5,6,4,7,8,9 };

            return samples;
        }

        private void RunForSorting(Action<int[]> action)
        {
            foreach(var sample in Samples())
            {
                action(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] array)
        {
            TestContext.WriteLine("------TRACE------\n");

            foreach(var el in array)
            {
                TestContext.Write($"{el} ");
            }

            TestContext.WriteLine("\n------------\n");
        }


        [Test]
        public void Test1()
        {
            RunForSorting(Sorting.BubbleSort);
        }
    }
}
