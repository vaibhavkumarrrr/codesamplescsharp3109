using System.Net.Http.Headers;

namespace FileAppcsharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"e:\dotnet2\sample.txt";
            FileStream s = null; 
            bool ok = false;
            //options.Access = FileAccess.Write|FileMode.OpenOrCreate
            try
            {
                s = new FileStream(path, FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.None);
                using (StreamWriter writer = new StreamWriter(s))
                {
                    writer.WriteLine("Line 1");
                    writer.WriteLine("Line 2");
                }
                if (s != null) s.Close();

            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Permission to create file: " + path + " is denied");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("**** Directory does not exist");
                DirectoryInfo f = new DirectoryInfo(path);
                FileInfo fi = new FileInfo(path);
                Console.WriteLine(fi.DirectoryName); 
                if (!f.Exists)
                {
                    try
                    {
                        // take only the base part of f
                        Directory.CreateDirectory(fi.DirectoryName);
                        //f.Create(); 
                        ok = true;
                        Console.WriteLine("*** Created directry"); 
                    }
                    catch {
                        Console.WriteLine("Cannot Create Directory " + f.FullName); 
                    }
                    finally
                    {
                        if (ok)
                        {
                            s = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Write);
                            using (StreamWriter writer = new StreamWriter(s))
                            {
                                writer.WriteLine("Line 1");
                                writer.WriteLine("Line 2");
                            }
                            if (s != null) s.Close();
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Other IO Exception"); 
            }

        }

        }
}
