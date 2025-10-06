using System;
using System.Collections.Generic;
/*
 * 
 * Using Two Pointers - O(n) Time and O(1) Space
 * The idea is to use two pointers, one from start and one from the end. 
 * Assume the start person is A, and the end person is B. 
 * If A knows B, then A must not be the celebrity. 
 * Else, B must not be the celebrity. 
 * At the end of the loop, only one index will be left as a celebrity. 
 * Go through each person again and check whether this is the celebrity. 
 * Create two indices i and j, where i = 0 and j = n-1
 * Run a loop until i is less than j.
 * Check if i knows j, then i can't be a celebrity. so increment i, i.e. i++
 * Else j cannot be a celebrity, so decrement j, i.e. j--
 * Assign i as the celebrity candidate
 * Now at last check whether the candidate is actually a celebrity by re-running a loop from 0 to n-1  and constantly checking if the candidate knows a person or if there is a candidate who does not know the candidate. Then we should return -1. else at the end of the loop, we can be sure that the candidate is actually a celebrity.
 */
public class CelebrityProblem
{

    static int celebrity(int[,] mat)
    {
        int n = mat.GetLength(0);

        int i = 0, j = n - 1;
        while (i < j)
        {

            // j knows i, thus j can't be celebrity
            if (mat[j, i] == 1)
                j--;

            // else i can't be celebrity
            else
                i++;
        }

        // i points to our celebrity candidate
        int c = i;

        // Check if c is actually
        // a celebrity or not
        for (i = 0; i < n; i++)
        {
            if (i == c) continue;

            // If any person doesn't
            // know 'c' or 'c' doesn't
            // know any person, return -1
            if (mat[c, i] != 0 || mat[i, c] == 0)
                return -1;
        }

        return c;
    }

    static void Main()
    {
        int[,] mat = { { 1, 1, 0 },
                       { 0, 1, 0 },
                       { 0, 1, 1 } };
        Console.WriteLine(celebrity(mat));
    }
}