using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO
{
    class DeleteDirectory
    { 
        static void Main(string[] args)
            {
                // Providing directory name with complete location.  
                DirectoryInfo directory = new DirectoryInfo(@"E:\BIZZZ\FileIO\directory");
                try
                {
                    // Deleting directory  
                    directory.Delete();
                    Console.WriteLine("The directory is deleted successfully.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong: {0}", e.ToString());
                }
            }
        }
    }  