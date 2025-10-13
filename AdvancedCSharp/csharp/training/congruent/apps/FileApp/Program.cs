using System.Net.Http.Headers;

string path = @"e:\dotnet2\sample.txt";
FileStream? s;
bool ok = false;
//options.Access = FileAccess.Write|FileMode.OpenOrCreate
try
{
    s = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
    Console.WriteLine("Stream s: " +s.Name);
    using (StreamWriter writer = new(s))
    {
        writer.WriteLine("Line 1");
        writer.WriteLine("Line 2");
    }
    s?.Close(); // check if null else close.. 

}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Permission to create file: " + path + " is denied");
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine("**** Directory does not exist");
    DirectoryInfo f = new(path);
    if (!f.Exists)
    {
        try
        {
            // take only the base part of f
            if (path != null)
            {
                string ? dirName = new FileInfo(path).DirectoryName;
                if (dirName != null)
                {
                    _ = Directory.CreateDirectory(dirName);
                    //f.Create(); 
                    ok = true;
                    Console.WriteLine("*** Created directry");
                }
            }
        }
        catch
        {
            Console.WriteLine("Cannot Create Directory " + f.FullName);
        }
        finally
        {
            if (ok)
            {
                s = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Write);
                using (StreamWriter writer = new(s))
                {
                    writer.WriteLine("Line 1");
                    writer.WriteLine("Line 2");
                }
                s?.Close(); // Check if s is null if not then close.. 
            }
        }
    }

}
catch (Exception)
{
    Console.WriteLine("Other IO Exception");
}
