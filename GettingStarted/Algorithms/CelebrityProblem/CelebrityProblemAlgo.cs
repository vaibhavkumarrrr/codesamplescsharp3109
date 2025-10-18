using System;
using System.Collections.Generic;
namespace csharp.training.congruent.algorithms
{
    public class CelebrityProblemAlgo
    {

/*
Using Adjacency List - O(n2) Time and O(n) Space

The idea is to model the problem as a directed graph 
where edges represent “knows” relationships.
A celebrity, if present, will be the single vertex with indegree = n 
and outdegree = 1, meaning they are known by everyone else 
but does not know anyone (except themselves).

*Create two arrays indegree and outdegree, to store the indegree and outdegree
* Run a nested loop, the outer loop from 0 to n and inner loop from 0 to n.
* For every pair i, j check if i knows j then increase the outdegree of i 
* and indegree of j.
* For every pair i, j check if j knows i then increase the outdegree of j 
* and indegree of i.
* Run a loop from 0 to n and find the id where the indegree is n and 
* outdegree is 1.
*/

        public static int SolveUsingAdjacenyMatrix(int[,] mat)
        {
            int n = mat.GetLength(0);

            // indegree and outdegree array
            int[] indegree = new int[n];
            int[] outdegree = new int[n];

            // query for all edges
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int x = mat[i, j];

                    // set the degrees
                    outdegree[i] += x;
                    indegree[j] += x;
                }
            }

            // find a person with indegree n-1
            // and out degree 0
            for (int i = 0; i < n; i++)
                if (indegree[i] == n && outdegree[i] == 1)
                    return i;

            return -1;
        }

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


        public static int SolveUsingStack(int[,] mat)
        {
            int n = mat.GetLength(0);
            Stack<int> st = new();

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
        public static int SolveUsingTwoPointers(int[,] mat)
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



    }
}
