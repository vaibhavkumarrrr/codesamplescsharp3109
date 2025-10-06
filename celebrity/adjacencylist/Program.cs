using System;
using System.Collections.Generic;

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

public class CelebrityProblem
{

    static int celebrity(int[,] mat)
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

    public static void Main()
    {
        int[,] mat = { { 1, 1, 0 },
                       { 0, 1, 0 },
                       { 0, 1, 1 } };
        Console.WriteLine(celebrity(mat));
    }
}