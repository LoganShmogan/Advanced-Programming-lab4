namespace AlgoDS.DataStructures
{

    public class LinkedList { }
    public class Stack { }
    public class Queue { }
    public class HashTable { }

    public class LinkedList<T> { }
    public class Stack<T> { }
    public class Queue<T> { }
    public class HashTable<K, V> { }


}

namespace AlgoDS.Sorting
{
    public class QuickSort { }
    public class QuickSort<T> { }

}

namespace AlgoDS.Searching
{
    public class LinearSearch
    {
        public static int Ls(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key) return i;
            }
            return -1;
        }
    }
    public class BinarySearch
    {
        public static int Bs(int[] arr, int key)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == key) return mid; // Found key
                if (arr[mid] < key) left = mid + 1; // Search right
                else right = mid - 1; // Search left
            }
            return -1;
        }
    }
    public class LinearSearch<T>
    {
        public static int Ls(T[] arr, T key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(key)) return i;
            }
            return -1;
        }
    }
    public class BinarySearch<T> where T : IComparable<T>
    {
        public static int Bs(T[] arr, T key)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid].Equals(key)) return mid; // Found key
                if (arr[mid].CompareTo(key) < 0) left = mid + 1; // Search right
                else right = mid - 1; // Search left
            }
            return -1;
        }
    }

}