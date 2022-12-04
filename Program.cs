using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        //sort Bubble

        static int[] BubbleSort(int[] array)
        {

            int len = array.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int dopslot = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = dopslot;
                    }
                }
            }

            return array;
        }


        //sort Selection

        static int[] Selection(int[] array)
        {

            int len = array.Length,indx;

            for (int i = 0; i < len; i++)
            {
                indx = i;
                for (int j = i; j < len; j++) 
                {
                    if (array[j] < array[indx])
                    {
                        indx = j;
                    }
                }

                int dopslot = array[i];
                array[i] = array[indx];
                array[indx] = dopslot;
            }

            return array;
        }


        //Insertion sort

        static int[] Insertion(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    int dopslot = array[j-1];
                    array[j - 1] = array[j];
                    array[j] = dopslot;
                    j--;
                }

                array[j] = key;
            }

            return array;
        }

        static int[] SelectionSort(int[] array,int type)
        {
            switch (type)
            {
                case 1:
                    BubbleSort(array);
                    break;
                case 2:
                    Selection(array);
                    break;
                case 3:
                    Insertion(array);
                    break;
            }
            return array;
        }

        //print array

        static void PrintArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }


        static void Main()
        {
            int[] array = new int[5] {1,5,3,2,7};
            SelectionSort(array,3);
            PrintArray(array);
        }
    }
}