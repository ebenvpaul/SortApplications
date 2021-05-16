using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Merge Sort!");
            Console.Write("");
            List<int> unsorted = new List<int>();
            List<int> sorted;

            Random random = new Random();
            string tabs = "=";
            Console.WriteLine("Original array elements:");

            for (int i = 0; i < 10; i++)
            {
                int randomno = random.Next(0, 100);
                unsorted.Add(randomno);
            }
            foreach (int element in unsorted)
            {
                tabs = new String('=', element);
                Console.Write(tabs + " " + element + "\n");
            }
            Console.WriteLine();

            Console.Write("\n");
            sorted = MergeSort(unsorted);
            Console.WriteLine("Sorted array elements: ");

            foreach (int x in sorted)
            {
                tabs = new String('=', x);
                Console.Write(tabs + " " + x + "\n");
         
            }
            Console.Write("\n");

            Console.ReadKey();


        }


        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }


        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }

}

