using System;
using System.Collections;
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
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = String.Empty;
        }

        // Fibonacci button click event
        private void button2_Click(object sender, EventArgs e)
        {
            //int[] array = SearchForm.ConvertToIntArray(txtArray.Text..Split(','));
            int fLength = Convert.ToInt32(txtArrayLength.Text);
            int[] fibonacciSeries = FibonacciSeries(fLength, new int[fLength], 0);
            txtResult.Text = String.Join(", ", fibonacciSeries);
        }

        public int[] FibonacciSeries(int fLength, int[] array, int index)
        {
            if (fLength == index)
                return array;
            if (index == 0)
                array[index] = 0;
            else if (index == 1)
                array[index] = 1;
            else {
                array[index] = array[index - 1] + array[index - 2];
            }
            return FibonacciSeries(fLength, array, index + 1);
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            int[] array1 = SearchForm.ConvertToIntArray(txtArray1.Text.Split(','));
            int[] array2 = SearchForm.ConvertToIntArray(txtArray2.Text.Split(','));
            //int desired = Convert.ToInt32(txtArrayLength.Text);
            bool[] finalArray = BitwiseXOR(array1, array2);
            txtResult.Text = String.Join(", ", finalArray);
        }

        public bool[] BitwiseXOR(int[] array1, int[] array2)
        {
            //Find pairs
            bool value1, value2;
            int index = 0;
            int smallLength = array1.Length < array2.Length ? array1.Length : array2.Length;
            //int bigLength = array1.Length > array2.Length ? array1.Length : array2.Length;
            bool[] finalArray = new bool[smallLength];
            for (; index < smallLength; index++)
            {
                value1 = Convert.ToBoolean(array1[index]);
                value2 = Convert.ToBoolean(array2[index]);
                if (index <= smallLength - 1)
                    finalArray[index] = value1 ^ value2;
            }
            return finalArray;
        }

        private void btnSquareandSort_Click(object sender, EventArgs e)
        {
            //Given a array of both positive and negative integers ‘arr[]’ which are sorted. Task is to sort square of the numbers of the Array.
            int[] array = SearchForm.ConvertToIntArray(txtArray1.Text.Split(','));
            int length = Convert.ToInt32(txtArrayLength.Text);
            array = SquareAndSort(array, 0, length - 1);
            txtResult.Text = String.Join(", ", array);
        }

        public int[] SquareAndSort(int[] array, int start, int end)
        {
            //-6,-3,-1,0,2,6,9
            //0,1,4,9,36,36,81
            int mid = (end - start) / 2 + start;
            if (start < end)
            {
                array = SquareAndSort(array, start, mid);
                array = SquareAndSort(array, mid + 1, end);
            }
            array = Merge(array, start, end, mid);
            return array;
        }

        public int[] Merge(int[] array, int start, int end, int mid)
        {
            int num1, num2;
            if (start >= end)
            {
                array[start] = SquareNum(array[start]);
                return array;
            }

            int fIndex = start, lIndex = mid + 1, index = 0;
            int[] firstHalf = new int[mid - start + 1];
            int[] secondHalf = new int[end - mid];
            int[,] matrix = new int[10, 10];
            int[,,] matrix_3d = new int[10, 10, 10];
            List<int> l = new List<int>();
            ArrayList a = new ArrayList();
            a.Add("d");
            a.Add(3);

            while (fIndex <= mid || lIndex <= end)
            {
                if (fIndex <= mid && index <= mid - start + 1)
                {
                    firstHalf[index] = array[fIndex];
                    fIndex++;
                }
                if (lIndex <= end && index <= end - mid)
                {
                    secondHalf[index] = array[lIndex];
                    lIndex++;
                }
                index++;
            }
            fIndex = 0;
            lIndex = 0;
            index = start;
            while (fIndex < mid - start + 1 && lIndex < end - mid)
            {
                num1 = firstHalf[fIndex];
                num2 = secondHalf[lIndex];
                if (num1 > num2)
                {
                    array[index] = num2;
                    lIndex++;
                }
                else
                {
                    array[index] = num1;
                    fIndex++;
                }
                index++;
            }

            while (fIndex < mid - start + 1)
            {
                num1 = firstHalf[fIndex];
                array[index] = num1;
                fIndex++;
                index++;
            }

            while (lIndex < end - mid)
            {
                num2 = secondHalf[lIndex];
                array[index] = num2;
                lIndex++;
                index++;
            }

            return array;
        }

        public int SquareNum(int num)
        {
            return num * num;
        }

        private void btnSumDifferences_Click(object sender, EventArgs e)
        {
            int[] array = SearchForm.ConvertToIntArray(txtArray1.Text.Split(','));
            int length = Convert.ToInt32(txtArrayLength.Text);
            int sum;
            txtArray2.Text = String.Join(", ", SumDifferences(array, length, out sum));
            txtResult.Text = Convert.ToString(sum);
        }

        public int[] SumDifferences(int[] array, int length, out int sum)
        {
            //Maximize sum consecutive differences in a circular array
            //sort the array
            //then arrange them alternate 
            SortArray(array, 0, length - 1, length - 1);
            int start = 0, end = length - 1;
            int index = 0;
            sum = 0;
            while (start < end)
            {
                sum += (array[end] - array[start]);
                if (index % 2 == 0)
                    start++;
                else
                    end--;
                index++;
            }
            if (length % 2 == 0)
                sum += array[start] - array[0];
            else
                sum += array[end] - array[0];
            return array;
        }

        public int[] SortArray(int[] array, int start, int pivot, int end)
        {
            if (pivot <= start)
                return array;
            else
            {
                int num1, num2, index = start;
                while (pivot > start && index < pivot)
                {
                    num1 = array[index];
                    num2 = array[pivot];
                    if (pivot - index == 1 && num1 > num2)
                    {
                        array[index] = num2;
                        array[pivot] = num1;
                        pivot--;
                    }
                    else if (num1 > num2)
                    {
                        array[index] = array[pivot - 1];
                        array[pivot] = num1;
                        array[pivot - 1] = num2;
                        pivot--;
                    }
                    else
                        index++;
                }
            }
            SortArray(array, start, pivot - 1, end);
            SortArray(array, pivot + 1, end, end);
            return array;
        }

        private void btnBeforeAndAfter_Click(object sender, EventArgs e)
        {
            //A permutation where each element indicates either number of elements before or after it
            int[] array = SearchForm.ConvertToIntArray(txtArray1.Text.Split(','));
            int length = Convert.ToInt32(txtArrayLength.Text);
            txtResult.Text = BeforeAndAfter(array, length).ToString();
        }

        public bool BeforeAndAfter(int[] array, int length)
        {
            int[] cArray = array;
            //int[] result = new int[length];
            bool result = true;
            int index = 0, before = 0, after = length - 1;
            for (; index < length; index++)
            {
                // 4 1 2 3 0
                //SearchForElement(cArray,before,length)
                if (cArray[index] == before || cArray[index] == after)
                {
                    before++;
                    after--;
                }
                else
                    return false;
            }
            return result;
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            char[] array = txtArray1.Text.Trim().ToLower().ToCharArray();
            QuickSort(array, 0, array.Length - 1);
            txtResult.Text = String.Join(", ", array);
        }

        public void QuickSort(char[] arr, int low, int high)
        {
            if (low < high)
            {
                int partition = Partition(arr, low, high);
                QuickSort(arr, low, partition - 1);
                QuickSort(arr, partition + 1, high);
            }
        }

        public int Partition(char[] arr, int low, int high)
        {
            int partition = low - 1;
            int pivot = (int)arr[high];
            int ascii;
            for (int index = low; index < high; index++)
            {
                ascii = (int)arr[index];
                char temp;
                if (pivot > ascii)
                {
                    partition++;
                    temp = arr[index];
                    arr[index] = arr[partition];
                    arr[partition] = temp;
                }
            }
            char t = arr[partition + 1];
            arr[partition + 1] = (char)pivot;
            arr[high] = t;
            return partition + 1;
        }

        private void btnMerge2_Click(object sender, EventArgs e)
        {
            int[] array = SearchForm.ConvertToIntArray(txtArray1.Text.Split(','));
            array = MergeSort(array, 0, array.Length - 1);
            string result = String.Join(",", array);
            txtResult.Text = result;
        }

        public int[] MergeSort(int[] array, int start, int end)
        {
            // 3 5 1 7 8

            int mid = start + (end - start) / 2;
            if (end - start > 1)
            {
                array = MergeSort(array, start, mid);//0 2
                array = MergeSort(array, mid + 1, end);//
            }
            array = Merge2(array, start, end, mid);// 0 2 1
            return array;
        }

        public int[] Merge2(int[] array, int start, int end, int mid)
        {
            if (end == start)
                return array;
            else if (end - start == 1)
            {
                if (array[start] > array[end])
                {
                    int buffer = array[end];
                    array[end] = array[start];
                    array[start] = buffer;
                }
                return array;
            }
            else
            {
                //3 5 1
                int[] firstHalf = new int[mid - start + 1];
                int[] secondHalf = new int[end - mid];
                int smallerLength = firstHalf.Length > secondHalf.Length ? secondHalf.Length : firstHalf.Length;//1
                int index = 0, f_index = 0, s_index = 0;
                for (; index < smallerLength; index++)
                {
                    firstHalf[index] = array[start + index];
                    secondHalf[index] = array[mid + 1 + index];
                }

                if (index < firstHalf.Length)
                    firstHalf[index] = array[start + index];
                if (index < secondHalf.Length)
                    secondHalf[index] = array[mid + 1 + index];

                index = 0;
              
                while (f_index < firstHalf.Length && s_index < secondHalf.Length)
                {
                    if (firstHalf[f_index] < secondHalf[s_index])
                    {
                        array[start + index] = firstHalf[f_index];
                        f_index++;
                    }
                    else
                    {
                        array[start + index] = secondHalf[s_index];
                        s_index++;
                    }
                    index++;
                }

                while (f_index < firstHalf.Length)
                {
                    array[start + index] = firstHalf[f_index];
                    f_index++;
                    index++;
                }
                while (s_index < secondHalf.Length)
                {
                    array[start + index] = secondHalf[s_index];
                    s_index++;
                    index++;
                }

                return array;
            }
        }

        private void btnQuick2_Click(object sender, EventArgs e)
        {
            int[] array = SearchForm.ConvertToIntArray(txtArray1.Text.Split(','));
            array = QuickSort2(array, 0, array.Length-1);
            string result = String.Join(",", array);
            txtResult.Text = result;
        }

        public int[] QuickSort2(int[] array, int low, int high)
        {
            if (high <= low)
                return array;
            else if (high - low == 1)
            {
                if (array[low] > array[high])
                    SwapArrayIntegers(array, low, high);
                return array;
            }
            // 1 3 5 7
            int pivot = Partition(array, low, high);
            array = QuickSort2(array, low, pivot - 1);//
            array = QuickSort2(array, pivot + 1, high);//
            return array;
        }

        public int Partition(int[] array, int low, int high)
        {
            int smallIndex = low - 1, index = low;

            for (; index < high; index++)
            {
                if (array[index] <= array[high])
                {
                    smallIndex++;
                    if (smallIndex != index)
                        SwapArrayIntegers(array, smallIndex, index);
                }
            }

            smallIndex++;
            if(smallIndex != high)
                SwapArrayIntegers(array, smallIndex, high);

            return smallIndex;
        }

        public void SwapArrayIntegers(int[] array, int smallIndex, int index)
        {
            int buffer = array[index];
            array[index] = array[smallIndex];
            array[smallIndex] = buffer;
        }
    }
}

