using System.Numerics;
using csharp.training.congruent.classes; 
namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static T sumArrayList<T>(List<T> arr) where T : INumber<T>
        {
            T total = T.Zero;
            foreach (var item in arr)
            {
                total += item;
            }
            return total;
        }
        static void Main(string[] args)
        {
            // Simple code to show 
            // Use of List<T> and generics
            // see the static function sumArrayList 
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int sum = sumArrayList(list);
            Console.WriteLine(sum);

            List<double> list2 = new List<double>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            double sum2 = sumArrayList(list2);
            Console.WriteLine(sum2);

            // Simple LINQ example
            var x = list.Select(x => x).Where(x => (x % 2 != 0));
            foreach (var y in x)
            {
                Console.WriteLine(y);
            }

            IEnumerable<Dog> dogList =
     new List<Dog>
     { new Dog("Sriram"), new Dog("Bruno") };
            IEnumerable<Cat> catList =
                new List<Cat>
                { new Cat("Dilbert"), new Cat("Greta") };
            IEnumerable<Animal> varTest = dogList;


            foreach (var dogsorcats in varTest) dogsorcats.Announce();
            {
                varTest = catList;

                foreach (var dogsorcats in varTest) dogsorcats.Announce();
                var names = varTest.Select(a => a.Name);
                foreach (var tmpName in names) Console.WriteLine($"Animal Name: {tmpName}");
            }
            {
                varTest = dogList;

                foreach (var dogsorcats in varTest) dogsorcats.Announce();
                var names = varTest.Select(a => a.Name);
                foreach (var tmpName in names) Console.WriteLine($"Animal Name: {tmpName}");
            }


        }
    }
}
