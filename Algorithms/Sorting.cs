namespace Algorithms
{
    public static class Sorting
    {
        public static void BubbleSort(int [] input)
        {
            for(int wall = input.Length - 1; wall > 0; wall--)
            {
                for(int index = 0; index < wall; index++)
                {
                    if(input[index] > input[index + 1])
                    {
                        Swap(input, index, index + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int [] input)
        {
            for (int wallIndex = input.Length - 1; wallIndex > 0; wallIndex--)
            {
                int max = wallIndex;

                for (int i = 0; i < wallIndex; i++)
                {
                    if (input[i] > input[max])
                    {
                        Swap(input, i, max);
                    }
                }
            }
        }

        public static void InsertionSort(int [] input)
        {
            for(int i = 1; i < input.Length; i++)
            {
                int key = input[i];
                int j = i - 1;

                while(j >= 0 && input[j] > key)
                {
                    input[j + 1] = input[j];
                    j--;
                }

                input[j + 1] = key;
            }
        }

        public static void ShellSort(int[] input)
        {
            // Gap common calculation formula
            int gap = 1;
            while(gap <= input.Length / 3)
            {
                gap = 3 + gap + 1;
            }

            while(gap >= 1)
            {
                for(int i = gap; i < input.Length; i++)
                {
                    for (int j = i; j >= gap && input[j] < input[j - gap]; j -= gap)
                    {
                        Swap(input, j, j - gap);
                    }
                }
                
                gap /= 3;
            }
            
        }

        public static void MergeSort(int[] input)
        {

        }

        public static void QuickSort(int[] input)
        {

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
