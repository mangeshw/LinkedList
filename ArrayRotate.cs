using System;
using System.Collections.Generic;

public class GFG
{
    static public void ConstructSolution()
    {
        //Console.WriteLine("Hello World!");
        int testCases = int.Parse(Console.ReadLine());
        //Console.WriteLine("# of test cases are: " + testCases.ToString());
        int len;
        List<int[]> cases = new List<int[]>();
        for (int index = 0; index < testCases; index++)
        {
            len = int.Parse(Console.ReadLine());
            //Edge cases for this array -> if length is zero
            string[] strArray = Console.ReadLine().Split(' ');
            int[] intArray = new Int32[len];

            for (int idx = 0; idx < len; idx++)
            {
                intArray[idx] = Convert.ToInt32(strArray[idx]);
            }
            cases.Add(intArray);
        }
        //Console.WriteLine(cases.Count.ToString());

        foreach (int[] arr in cases)
        {
            int output = PerformOperation(arr);
            //Function call - array specific, will return the number to be printed
            Console.WriteLine(output.ToString());
        }

    }

    public static int PerformOperation(int[] array)
    {
        //Call Rotate and Delete, this will return array for next pass
        bool nextPass = true;
        int elementIdx = 0;
        while (nextPass)
        {
            elementIdx++;
            string a = String.Join(",", array);
            Console.WriteLine("String is: " + a);
            array = RotateAndDelete(array, ref nextPass, elementIdx);
        }
        return array[0];
    }

    public static int[] RotateAndDelete(int[] array, ref bool nextPass, int elementIdx)
    {
        Console.WriteLine("elementIdx is: " + elementIdx.ToString());
        Console.WriteLine("array.Length is: " + array.Length.ToString());
        if (array.Length <= elementIdx)
        {
            Console.WriteLine("Inside If loop");
            nextPass = false;
            return array;
        }
        Console.WriteLine("After If loop");
        int[] newArray = new int[array.Length - 1];
        int newIdx = 0;
        string s = String.Join(",", newArray);
        Console.WriteLine("Before Loop new array: " + s);
        for (int index = 0; index < array.Length; index++)
        {
            if (index == array.Length - 1 - elementIdx)
                index++;
            continue;
            if (index == array.Length - 1)
                newArray[0] = array[index];
            else
                newArray[newIdx] = array[index];
            newIdx++;
        }
        s = String.Join(",", newArray);
        Console.WriteLine("Returning new array: " + s);
        return newArray;
    }
}