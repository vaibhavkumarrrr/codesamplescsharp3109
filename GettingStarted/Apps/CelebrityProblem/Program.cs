using csharp.training.congruent.algorithms;
namespace csharp.training.congruent.apps
{

    internal class Program
    {
        static void Main(string[] _)
        {
            //Console.WriteLine("Hello, World!");
            int[,] mat = { { 1, 1, 0 },
                       { 0, 1, 0 },
                       { 0, 1, 1 } };
            Console.WriteLine($"Solved using Adjacency Matrix {CelebrityProblemAlgo.SolveUsingAdjacenyMatrix(mat)}");
            Console.WriteLine($"Solved using Stack {CelebrityProblemAlgo.SolveUsingStack(mat)}");
            Console.WriteLine($"Solved using Two Pointers {CelebrityProblemAlgo.SolveUsingTwoPointers(mat)}");

        }
    }
}
