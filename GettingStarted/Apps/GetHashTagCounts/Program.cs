using System.Text.RegularExpressions;
namespace csharp.training.congruent.apps
{
    internal partial class Program
    {
        static void Main(string[] _)
        {
            var input = "asdads sdfdsf #burgers, #rabbits dsfsdfds #sdf #dfgdfg #sdf #sdf";
            //var regex = new Regex(@"#\w+");
            var regex = MyRegex();
            var matches = regex.Matches(input);
            Dictionary<string, int> dict = [];

            // https://stackoverflow.com/questions/289/how-do-you-sort-a-dictionary-by-value 
            if (matches is not null)
            {
                foreach (var match in matches)
                {
                    if (match is not null)
                    {
                        // REALLY REALLY DEFENSIVE CODING...
                        string? s = match?.ToString(); 
                        var key = dict.ContainsKey(s!) ? s! : s!.ToLower();
                        if (dict.TryGetValue(key, out int value))
                        {
                            dict[key] = ++value;
                        }
                        else
                        {
                            dict[key] = 1;
                        }
                    }
                }
            }
            //System.Collections.Generic.S
            var sortedDict = from entry in dict orderby entry.Value descending select entry;
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        [GeneratedRegex(@"#\w+")]
        private static partial Regex MyRegex();
    }
}
