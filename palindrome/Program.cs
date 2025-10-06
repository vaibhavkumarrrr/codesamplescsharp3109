// See https://aka.ms/new-console-template for more information

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