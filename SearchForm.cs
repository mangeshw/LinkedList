using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public static int[] ConvertToIntArray(string[] sArray)
        {
            int[] array = new Int32[sArray.Length];
            for (int index = 0; index < sArray.Length; index++)
            {
                array[index] = Convert.ToInt32(sArray[index]);
            }
            return array;
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            string stringArray = txtArray.Text;
            string[] sArray = stringArray.Split(',');
            int[] array = SearchForm.ConvertToIntArray(sArray);
            int arrayLength = Convert.ToInt32(txtArrayLength.Text);
            int midIndex = (arrayLength / 2);
            int searchFor = Convert.ToInt32(txtSearchFor.Text);
            txtResult.Text = BinarySearch(array, 0, arrayLength - 1, searchFor).ToString();
        }

        public int BinarySearch(int[] array, int start, int end, int searchFor)
        {
            int midIndex = start + (end - start) / 2;
            if (start == end && array[midIndex] != searchFor)
                return -1;
            else if (array[midIndex] == searchFor)
                return midIndex;
            else if (array[midIndex] > searchFor)
            {
                return BinarySearch(array, start, midIndex - 1, searchFor);
            }
            else {
                return BinarySearch(array, midIndex + 1, end, searchFor);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = String.Empty;
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            int[] array = SearchForm.ConvertToIntArray(txtArray.Text.Split(','));
            array = MergeSort(array, 0, Convert.ToInt32(txtArrayLength.Text) - 1);
            txtResult.Text = String.Join(", ", array);
        }

        private int[] MergeSort(int[] array, int start, int end)
        {
            int midIndex = start + (end - start) / 2;
            if (start < end)
            {
                //1st half
                MergeSort(array, start, midIndex);
                //2nd half
                MergeSort(array, (midIndex + 1), end);
            }

            //Merge Both
            Merge(array, start, midIndex, end);
            return array;
        }

        private int[] Merge(int[] array, int start, int mid, int end)
        {
            if (start == end)
                return array;
            //else if(end - start == 1)
            //{
            //    if (array[end] < array[start])
            //    {
            //        buffer = array[end];
            //        array[end] = array[start];
            //        array[start] = buffer;
            //    }
            //}

            int[] firstHalf = new int[mid - start + 1];
            int[] secondHalf = new int[end - mid];
            int fIndex = 0, lIndex = 0;

            while (fIndex < mid - start + 1 || lIndex < end - mid)
            {
                if (fIndex < mid - start + 1)
                {
                    firstHalf[fIndex] = array[start + fIndex];
                    fIndex++;
                }

                if (lIndex < end - mid)
                {
                    secondHalf[lIndex] = array[mid + 1 + lIndex];
                    lIndex++;
                }
            }
            fIndex = 0;
            lIndex = 0;
            int index = 0;
            while (fIndex < mid - start + 1 && lIndex < end - mid)
            {
                if (firstHalf[fIndex] > secondHalf[lIndex])
                {
                    array[start + index] = secondHalf[lIndex];
                    lIndex++;
                }
                else
                {
                    array[start + index] = firstHalf[fIndex];
                    fIndex++;
                }
                index++;
            }

            while (fIndex < mid - start + 1)
            {
                array[start + index] = firstHalf[fIndex];
                fIndex++;
                index++;
            }
            while (lIndex < end - mid)
            {
                array[start + index] = secondHalf[lIndex];
                lIndex++;
                index++;
            }
            return array;
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            int[] array = SearchForm.ConvertToIntArray(txtArray.Text.Split(','));
            int arrayLength = Convert.ToInt32(txtArrayLength.Text);
            array = QuickSort(array, 0, arrayLength - 1, arrayLength - 1);
            txtResult.Text = String.Join(", ", array);
        }

        private int[] QuickSort(int[] array, int start, int end, int pivot)
        {
            if (start >= end)
                return array;
            else if(end-start == 1)
            {
                int buffer;
                if(array[start] > array[end])
                {
                    buffer = array[end];
                    array[end] = array[start];
                    array[start] = buffer;
                }
                return array;
            }
            //pivot aya hai
            //select pivot elements position
            //put pivot in right place
            int index = start;
            int buffer1, buffer2;
            while (index < pivot)
            {
                if ((array[index] > array[pivot]) && (index+1 != pivot))
                {
                    buffer1 = array[pivot];
                    array[pivot] = array[index];
                    buffer2 = array[pivot - 1];
                    array[pivot - 1] = buffer1;
                    array[index] = buffer2;
                    pivot--;
                    //index++;
                }
                else if((array[index] > array[pivot]) && (index+1 == pivot))
                {
                    buffer1 = array[pivot];
                    array[pivot] = array[index];
                    array[index] = buffer1;
                    //index++;
                    pivot--;
                }
                else
                    index++;
            }

            QuickSort(array, start, pivot - 1, pivot - 1);
            QuickSort(array, pivot + 1, end, end);
            // split into 2 - first half and second half
            return array;
        }
    }
}
