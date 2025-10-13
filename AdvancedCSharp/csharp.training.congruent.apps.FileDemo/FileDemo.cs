using System;
using System.IO;
using System.Security;
using System.Collections.Generic;
namespace csharp.training.congruent.apps.FileDemo
{
    internal class FileDemo
    {
        public static void WriteTextToFile(string filePath, string content)
        {
            try
            {
                // Step 1: Validate drive existence
                string? driveRoot = Path.GetPathRoot(filePath);
                if (!Directory.Exists(driveRoot))
                {
                    Console.WriteLine($"Error: Drive '{driveRoot}' does not exist.");
                    return;
                }

                // Step 2: Ensure directory structure exists
                string? directoryPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryPath))
                {
                    List<string> missingComponents = [];
                    string[]? parts = directoryPath?.Split(Path.DirectorySeparatorChar);
                    string? currentPath = parts?[0] + Path.DirectorySeparatorChar;

                    for (int i = 1; i < parts?.Length; i++)
                    {
                        currentPath = Path.Combine(currentPath, parts[i]);
                        if (!Directory.Exists(currentPath))
                        {
                            missingComponents.Add(currentPath);
                            try
                            {
                                Directory.CreateDirectory(currentPath);
                                Console.WriteLine($"Created missing directory: {currentPath}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Failed to create directory '{currentPath}': {ex.Message}");
                                return;
                            }
                        }
                    }

                    if (missingComponents.Count > 0)
                    {
                        Console.WriteLine("Missing directory components:");
                        foreach (var dir in missingComponents)
                            Console.WriteLine($" - {dir}");
                    }
                }

                // Step 3: Open file in exclusive mode and write
                using FileStream fs = new(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
                using StreamWriter writer = new(fs);
                writer.Write(content);
                Console.WriteLine("Text written successfully.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Permission error: {ex.Message}");
            }
            catch (SecurityException ex)
            {
                Console.WriteLine($"Security exception: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        public static void Main()
        {
            // ERROR CONDITION: Try ".\a.txt" 
            string filePath = @"g:.\output.txt";
            // Check wth 
            // g:\output.txt 
            // c:\abc\def\a.txt 
            // c:\training\a.txt 
            // c:\training\xxx\yyy\zzz.txt 
            string content = "Hello, this is exclusive file writing with robust error handling!";
            WriteTextToFile(filePath, content);
        }
    }
}