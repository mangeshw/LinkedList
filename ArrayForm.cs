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
                    if (pivot-index == 1 && num1 > num2)
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
            for(;index < length; index++)
            {
                // 4 1 2 3 0
                //SearchForElement(cArray,before,length)
                if(cArray[index] == before || cArray[index] == after)
                {
                    before++;
                    after--;
                }
                else
                    return false;
            }
            return result;
        }
        
    }
}

