using System;

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
            int[] aux = new int [input.Length];
            Sort(0, input.Length - 1);

            void Sort(int low, int high)
            {
                if(high <= low)
                {
                    return;
                }

                int mid = (low + high) / 2;

                Sort(low, mid);
                Sort(mid + 1, high);

                Merge(low, mid, high);

            }

            void Merge(int low, int mid, int high)
            {
                int i = low;
                int j = mid + 1;

                Array.Copy(input, low, aux, low, high - low + 1);

                for(int k = low; k <= high; k++)
                {
                    if(i > mid)
                    {
                        input[k] = aux[j++];
                    }
                    else if(j > high)
                    {
                        input[k] = aux[i++];
                    }
                    else if (aux[j] < aux[i])
                    {
                        input[k] = aux[j++];
                    }
                    else
                    {
                        input[k] = aux[i++];
                    }
                }       
            }
        }

        public static void QuickSort(int[] input)
        {
            Sort(0, input.Length - 1);

            void Sort(int low, int high)
            {
                if(high <= low)
                {
                    return;
                }

                int j = Partition(low, high);
                Sort(low, j-1);
                Sort(j + 1, high);
            }

            int Partition(int low, int high)
            {
                int i = low;
                int j = high + 1;

                int pivot = input[low];

                while (true)
                {
                    while(input[++i] < pivot)
                    {
                        if(i == high)
                        {
                            break;
                        }
                    }

                    while (input[--j] > pivot)
                    {
                        if (j == low)
                        {
                            break;
                        }
                    }

                    if(i >= j)
                    {
                        break;
                    }

                    Swap(input, i, j);
                }

                Swap(input, low, j);

                return j;
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
