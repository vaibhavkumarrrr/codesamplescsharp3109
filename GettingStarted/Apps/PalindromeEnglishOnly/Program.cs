namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPalindrome = false;
            string a = "madam";

            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
                isPalindrome = true;
            }

            Console.WriteLine($"The given string {a} is palindrome: {isPalindrome}");
        }
    }
}
