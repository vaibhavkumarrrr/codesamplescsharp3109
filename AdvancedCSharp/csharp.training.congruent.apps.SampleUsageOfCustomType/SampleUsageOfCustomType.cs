using csharp.training.congruent.classes;
using System; 
namespace csharp.training.congruent.apps.SampleUsageOfCustomType
{
    public class AppException: System.ApplicationException
    {
        public AppException():base(){}
        public AppException(string message):base(message){}
    }

    internal class SampleUsageOfCustomType
    {
        static void Main(string[] _)
        {
            try
            {
                throw new Exception("Test Exception");
            }
            catch 
            {
            }

            EvenUInt a = new(16); 
            uint u = new EvenUInt(4);
            Console.WriteLine($"u value: {u}");
            u = a;
            Console.WriteLine($"u value: {u}");
            try
            {
                EvenUInt u2 = new(2); // Change it to 1 to see what happens
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
