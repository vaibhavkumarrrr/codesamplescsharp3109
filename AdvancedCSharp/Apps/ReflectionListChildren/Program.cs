using System.Reflection;
using System.Reflection.Metadata;   


namespace csharp.training.congruent.apps
{
    

    internal class Program
    {
        static void PrintExceptionNames(string ?s)
        {

            if (s == null) return; 
            try
            {
                Console.WriteLine($"************ Getting Exception classes from {s}");
                Type[]? children = GetInheritedClasses(Type.GetType(s));
                if (children != null)
                {
                    foreach (Type c in children)
                    {
                        if (c.FullName!.EndsWith("Exception")) Console.WriteLine(c.FullName);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); return;
            }


            }
        static Type[]? GetInheritedClasses(Type? MyType)
        {

            //if you want the abstract classes drop the !TheType.IsAbstract but it is probably to instance so its a good idea to keep it.
            if(MyType == null) return null;
            //Console.WriteLine($"MyType {MyType.FullName}");
            //return Assembly.GetAssembly(MyType!)!.GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(MyType!)) as Type[];
            return Assembly.GetAssembly(MyType!)!.GetTypes() as Type[];
        }
        static void Main(string[] _)
        {
            PrintExceptionNames("System.Exception");
            PrintExceptionNames("System.SystemException");
            
        }
        /* fun code
         * Assembly asm = typeof(SomeKnownType).Assembly;
           Type type = asm.GetType(namespaceQualifiedTypeName);
           //or as a selection of a type in code.
            Type[] ChildClasses Assembly.GetAssembly(typeof(YourType)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(YourType))));
         */
    }
}
