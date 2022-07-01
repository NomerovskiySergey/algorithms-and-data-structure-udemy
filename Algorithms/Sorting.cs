using System;

namespace Algorithms
{
    public static class Sorting
    {
        public static void BubbleSort(int [] input)
        {
            for (int wallIndex = input.Length - 1; wallIndex > 0; wallIndex--)
            {
                for(int i = 0; i < wallIndex; i++)
                {
                    if(input[i] > input[i + 1])
                    {
                        Swap(input, i, i + 1);
                    }
                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }  
}
