using System;
using System.Collections;
using System.Collections.Generic;
// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Class2
{
    // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public List<string> reorderLines(int logFileSize, string[] logLines)
    {
        // WRITE YOUR CODE HERE
        /*
        Question: There is a file, it contains multiple single line entries. A line starts with an alphanumeric 
        identifier followed either by space separated words (only apphabets) or space separated numbers.

        You are required to sort the lines by text first lexicographically and then all lines with numbers should
        come in the given order. Sorting of text lines should be done on text first and then on identifier. Output
        should have identiifer first and then the text (as in given format).

        E.g.
        Input:
        a1 act car
        b1 4 6 8
        a2 bof gf
        ee3 54 4 6
        b9 act zoo

        Output:
        a1 act car
        b9 act zoo
        a2 bof gf
        b1 4 6 8
        ee3 54 4 6
        */
        
        string line;
        string[] arr;
        SortedList stringList = new SortedList();
        List<string> numbers = new List<string>();
        List<string> output = new List<string>();
        List<string> duplicates = new List<string>();
        string newLine = String.Empty;
        for (int index = 0; index < logFileSize; index++)
        {
            line = logLines[index];
            arr = line.Split(' ');
            //remove alpha from start and add to end
            //add to sort list
            int result;
            bool isNumber = int.TryParse(arr[1], out result);
            if (!isNumber)
            {
                newLine = String.Join(" ", arr, 1, arr.Length - 1);
                //before returning add alpha to start
                newLine += " " + arr[0];
                if (!stringList.ContainsKey(newLine))
                    stringList.Add(newLine, 0);
                else
                    duplicates.Add(line);
            }
            else
            {
                numbers.Add(line);
            }
        }
        line = String.Empty;
        
        for (int index = 0; index < stringList.Count; index++)
        {
            line = stringList.GetKey(index).ToString();
            arr = line.Split(' ');
            newLine = arr[arr.Length - 1] + " ";
            newLine += String.Join(" ", arr, 0, arr.Length - 1);
            while (duplicates.Contains(newLine))
            {
                output.Add(newLine);
                duplicates.Remove(line);
            }
            if (duplicates.Contains(newLine))
                output.Add(newLine);
            output.Add(newLine);
        }

        output.AddRange(numbers);
        return output;
    }
    // METHOD SIGNATURE ENDS
}