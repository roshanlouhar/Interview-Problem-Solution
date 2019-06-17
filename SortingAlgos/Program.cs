using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int n = arr.Length;

            Console.WriteLine("Unsorted array");
            printArray(arr, n);
                        
            //Console.WriteLine("\nbubbleSort Sorted array");
            //ObjSort.bubbleSort(arr, n);

            //Console.WriteLine("\nSelectionSort Sorted array");
            //ObjSort.SelectionSort(arr, n);

            //Console.WriteLine("\nInsertionSort Sorted array");
            //ObjSort.InsertionSort(arr, n);

            //Console.WriteLine("\nBinary Search");
            //int x = 12;
            //int result = ObjSort.BinarySearch(arr, 0, n - 1, x);
            //if (result == -1) Console.WriteLine("Element not present");
            //else Console.WriteLine("Element found at index " + result);

            //Console.WriteLine("\nMergeSort Sorted array");
            //ObjSort.MergeSort(arr, 0, n-1);

            //Console.WriteLine("\nQuickSort Sorted array");
            //ObjSort.QuickSort(arr, 0, n-1);

            //Console.WriteLine("\nHeapSort Sorted array");
            //ObjSort.HeapSort(arr);

            //Console.WriteLine("\nRadixSort Sorted array");
            //ObjSort.RadixSort(arr, n);

            //Console.WriteLine("\nShellSort Sorted array");
            //ObjSort.ShellSort(arr);

            Console.WriteLine("\nCountingSort Sorted array");
            CountingSort(arr);

            printArray(arr, n);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void printArray(int[] arr, int size)
        {
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        public static void bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }

        public static void SelectionSort(int[] arr, int n)
        {
            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        public static void InsertionSort(int[] arr, int n)
        {
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key,  
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        public static int BinarySearch(int[] arr, int l, int r, int x)
        {
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid 
                if (arr[m] == x)
                    return m;

                // If x greater, ignore left half 
                if (arr[m] < x)
                    l = m + 1;

                // If x is smaller, ignore right half 
                else
                    r = m - 1;
            }
            // if we reach here, then element was 
            // not present 
            return -1;
        }

        public void MergeSort(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(numbers, left, mid);
                MergeSort(numbers, (mid + 1), right);
                merge(numbers, left, (mid + 1), right);
            }
        }

        static void  merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[right];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array) 
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // One by one extract an element from heap 
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end 
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap 
                heapify(arr, i, 0);
            }
        }

        public static void heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root 
            int l = 2 * i + 1; // left = 2*i + 1 
            int r = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far 
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree 
                heapify(arr, n, largest);
            }
        }

        public static void RadixSort(int[] arr, int n)
        {
            // Find the maximum number to know number of digits  
            int m = getMax(arr, n);

            // Do counting sort for every digit. Note that instead  
            // of passing digit number, exp is passed. exp is 10^i  
            // where i is current digit number  
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }

        public static int getMax(int[] arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }

        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n]; // output array  
            int i;
            int[] count = new int[10];

            //initializing all elements of count to 0 
            for (i = 0; i < 10; i++)
                count[i] = 0;

            // Store count of occurrences in count[]  
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains actual  
            //  position of this digit in output[]  
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array  
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now  
            // contains sorted numbers according to current digit  
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public static void ShellSort(int[] arr)
        {
            int n = arr.Length;

            // Start with a big gap,  
            // then reduce the gap 
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size. 
                // The first gap elements a[0..gap-1] are already 
                // in gapped order keep adding one more element 
                // until the entire array is gap sorted 
                for (int i = gap; i < n; i += 1)
                {
                    // add a[i] to the elements that have 
                    // been gap sorted save a[i] in temp and 
                    // make a hole at position i 
                    int temp = arr[i];

                    // shift earlier gap-sorted elements up until 
                    // the correct location for a[i] is found 
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];

                    // put temp (the original a[i])  
                    // in its correct location 
                    arr[j] = temp;
                }
            }
        }

        public static void CountingSort(int[] arr)
        {
            int n = arr.Length;

            // The output character array that 
            // will have sorted arr 
            int[] output = new int[n];

            // Create a count array to store  
            // count of inidividul characters  
            // and initialize count array as 0 
            int[] count = new int[256];

            for (int i = 0; i < 256; ++i)
                count[i] = 0;

            // store count of each character 
            for (int i = 0; i < n; ++i)
                ++count[arr[i]];

            // Change count[i] so that count[i]  
            // now contains actual position of  
            // this character in output array 
            for (int i = 1; i <= 255; ++i)
                count[i] += count[i - 1];

            // Build the output character array 
            // To make it stable we are operating in reverse order. 
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                --count[arr[i]];
            }

            // Copy the output array to arr, so 
            // that arr now contains sorted  
            // characters 
            for (int i = 0; i < n; ++i)
                arr[i] = output[i];
        }
    }
}
