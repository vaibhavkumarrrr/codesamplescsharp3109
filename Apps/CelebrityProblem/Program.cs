using csharp.training.congruent.algorithms;
namespace csharp.training.congruent.apps
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[,] mat = { { 1, 1, 0 },
                       { 0, 1, 0 },
                       { 0, 1, 1 } };
            Console.WriteLine($"Solved using Adjacency Matrix {CelebrityProblem.SolveUsingAdjacenyMatrix(mat)}");
            Console.WriteLine($"Solved using Stack {CelebrityProblem.SolveUsingStack(mat)}");
            Console.WriteLine($"Solved using Two Pointers {CelebrityProblem.SolveUsingTwoPointers(mat)}");

        }
    }
}
