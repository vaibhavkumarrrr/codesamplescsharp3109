using csharp.training.congruent.classes;
using System; 
namespace csharp.training.congruent.apps
{

    public class AppException: System.ApplicationException
    {
        public AppException():base(){}
        public AppException(string message):base(message){}

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("g:\\dotnet\\data.txt"))
            {
                writer.WriteLine("Line 1");
                writer.WriteLine("Line 2");
            }

            string path = @"g:\dotnet\abc\sample.txt";
            DriveInfo d = new DriveInfo(path);
            Console.WriteLine(d.DriveType);
            File.WriteAllText(path, "Hello, File Handling in C#!");
            Console.WriteLine("File created successfully.");

            try
            {
                throw new Exception("Test Exception");
            }
            catch (Exception ex)
            {
            }

            EvenUInt a = new(16); 
            uint u = new EvenUInt(4);
            Console.WriteLine($"u value: {u}");
            u = a;
            Console.WriteLine($"u value: {u}");
      

            try
            {
                EvenUInt u2 = new(1);
                Console.WriteLine($"u2 value: {u2}"); ;
                //EvenUInt u3 = new(0);
                //Console.WriteLine(u2 / u3); 
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                try
                {
                    throw new AppException("Some DB Error Occuurred, DB Could not be opened. ");              }
                catch 

                {

                    //Console.WriteLine(ex.Message);
                   Console.WriteLine("Some error occuurred. Please contact your sysadmin for help.");
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(" Other error = " + e.Message);
            }
            

            finally
            {
                EvenUInt u2 = (EvenUInt)0;
                Console.WriteLine($"u2 value: {u2}"); ;
            }
        }
    }
}
