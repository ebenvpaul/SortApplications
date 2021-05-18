using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SortProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Finish:
            Console.Clear();
            Console.WriteLine("Different Algoriths and Searches!");
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Merge Sort!");
            Console.Write("");
            List<int> unsorted = new List<int>();
            List<int> sorted;
            Random random = new Random();
            string tabs = "=";

            #region RandomUnSortedElements
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
            int[] array = new int[unsorted.Count];
            for (int i = 0; i < unsorted.Count; i++)
            {
                array[i] = Convert.ToInt32(unsorted[i]);
            }
            Console.WriteLine();
            #endregion

            Console.Write("\n");

         

            Console.WriteLine("Select the Operation");
            Console.WriteLine("Enter 1 for Merge Sort");
            Console.WriteLine("Enter 2 for Insertion Sort");
            Console.WriteLine("Enter 3 for Binary Search");
            Console.WriteLine("Any Other will Exit Application");
            Console.Write("\n");
            Console.WriteLine("Enter Your Prefered Operation");
            var _Input = Console.ReadLine();
            int intInput = 0;
            if (! string.IsNullOrEmpty(_Input))
            {
                intInput = Information.IsNumeric(_Input) ? Convert.ToInt16(_Input) : 0;
            }
            switch (intInput)
            {
               
                case 1:
                    Console.WriteLine("Selected Merge Sort");
                    #region MergeSortedElements
                    MergeSortAlgo mergeSortAlgo = new MergeSortAlgo();
                    sorted = mergeSortAlgo.MergeSort(unsorted);
                    Console.WriteLine("Merge Sorted array elements: ");
                    foreach (int x in sorted)
                    {
                        tabs = new String('=', x);
                        Console.Write(tabs + " " + x + "\n");
                    }
                    #endregion
                    Console.Write("\n");
                    break;
                case 2:
                    Console.WriteLine("Selected Insertion Sort");

                    #region InsertionSortedElements
                    InsertionSortAlgo insertionSortAlgo = new InsertionSortAlgo();
                    Console.WriteLine("Insertion Sorted array elements: ");
                   
                    foreach (int x in insertionSortAlgo.InsertionSort(array))
                    {
                        tabs = new String('=', x);
                        Console.Write(tabs + " " + x + "\n");
                    }
                    #endregion
                    break;

                case 3:
                    Console.WriteLine("Selected Binary Search");
                    #region BinarySearch
                    Console.WriteLine("Enter the Element to be Searched Search : ");
                    BinarySearchAlgo binarySearchAlgo  = new BinarySearchAlgo();
                    var SearchNode = Console.ReadLine();
                    Console.WriteLine("You have Entered : " +SearchNode);
                    int intSearchNode = 0;
                    if (!string.IsNullOrEmpty(SearchNode))
                    {
                        intSearchNode = Information.IsNumeric(SearchNode) ? Convert.ToInt16(SearchNode) : 0;
                    }
                    object obj= binarySearchAlgo.BinarySearchIterative(array, intSearchNode);
                    if (obj != null) Console.WriteLine("The Node of Seached Item "+ intSearchNode + "  is  : " + obj);
                    #endregion
                    break;

                case 0:
                    Console.WriteLine("Selected Wrong Option");
                    Console.WriteLine("Selected to Exit");
                    Thread.Sleep(2000);
                    return;

                default:
                    Console.WriteLine("Selected Wrong Option");
                    break;
            }

            Console.Write("\n");
            Console.ReadKey();

            goto Finish;

        }



    }

}

