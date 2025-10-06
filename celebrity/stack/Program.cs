using System;
using System.Collections.Generic;
/*
 * 
 * Using Stack - O(n) Time and O(n) Space
 * 
* The idea is to use a stack to eliminate non-celebrities by comparing pairs. 
* If one person knows the other, the first is discarded; 
* otherwise, the second is discarded. 
* Repeat until one candidate remains, then verify if they meet the celebrity 
* conditions.
* Create a stack and push all the ids in the stack.
* Run a loop while there are more than 1 element in the stack.
* Pop the top two elements from the stack (represent them as A and B)
* If A knows B, then A can't be a celebrity and push B in the stack. Else if A doesn't know B, then B can't be a celebrity push A in the stack.
* Assign the remaining element in the stack as the celebrity.
* Run a loop from 0 to n-1 and find the count of persons who knows the celebrity and the number of people whom the celebrity knows.
* => If the count of persons who knows the celebrity is n-1 and the count of people whom the celebrity knows is 0 then return the id of the celebrity else return -1.
 */
public class CelebrityProblem
{

    static int celebrity(int[,] mat)
    {
        int n = mat.GetLength(0);
        Stack<int> st = new Stack<int>();

        // push everybody in stack
        for (int i = 0; i < n; i++)
            st.Push(i);

        // Find a potential celebrity
        while (st.Count > 1)
        {

            int a = st.Pop();
            int b = st.Pop();

            // if a knows b
            if (mat[a, b] != 0)
            {
                st.Push(b);
            }
            else
            {
                st.Push(a);
            }
        }

        // Potential candidate of celebrity
        int c = st.Pop();

        // Check if c is actually
        // a celebrity or not
        for (int i = 0; i < n; i++)
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
        int[,] mat = { { 0, 1, 0 },
                       { 0, 0, 0 },
                       { 0, 1, 0 } };
        Console.WriteLine(celebrity(mat));
    }
}