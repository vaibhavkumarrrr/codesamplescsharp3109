namespace CustomExtensionMethods;
public static class MyExtensions
{
    public static int WordCount(this string str) => str.Split([' ', '.', '?'], StringSplitOptions.RemoveEmptyEntries).Length;
}
