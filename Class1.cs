using System;
using System.Collections.Generic;
using System.Text;
// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Class1
{
    // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public List<String> retrieveMostFrequentlyUsedWords(String literatureText,
                                                   List<String> wordsToExclude)
    {
        // WRITE YOUR CODE HERE

        /*
		Text: This is a sample text, which can be used as an input. if; there, is "ff" 
		then-what happens
		*/

        /*
        Question: Given a string (paragraph) find most frequent word. There is a list of words,
        these words should be excluded from calculation.
        */
        Stack<int> c = new Stack<int>();
        //c.Peek()
        //c.Pop();
        
        int rr = int.MaxValue;
        string[] words = literatureText.Split(' ');
        string[] i = null;
        //words.CopyTo(i, 0);
        Dictionary<string, int> dict = new Dictionary<string, int>();
        SortedList<int, int> d = new SortedList<int, int>();
        d.Add(-1, 3);
        d.Add(0, 1);
        d.Add(-2, 4);
        rr = d.Keys[0];
        rr = d[0];
        List < int > l = new List<int>();
        l.Add(4);
        l.Add(5);
        l.Add(6);
        l.Add(7);
        string s = "ssssssss";
        char[] ad = new char[10];
        StringBuilder builder = new StringBuilder(6);
        Array.Reverse(ad);
        d.Remove(99);
        //KeyValuePair<string, int> pair;
        int count = 0;
        int maxCount = 0;
        foreach (string word in words)
        {
            if (wordsToExclude.Contains(word))
                continue;
            if (dict.ContainsKey(word))
            {
                count = dict[word];
                count++;
                dict[word] = count;
            }
            else
            {
                dict.Add(word, 1);
                count++;
            }

            maxCount = maxCount < count ? count : maxCount;
            count = 0;
        }

        List<string> list = new List<string>();
        foreach (KeyValuePair<string, int> pair in dict)
        {
            if (pair.Value == maxCount)
            {
                if (!list.Contains(pair.Key))
                    list.Add(pair.Key);
            }
        }
        return list;
    }
    // METHOD SIGNATURE ENDS
}