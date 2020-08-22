using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO
{
    class CreateDirectory
    { 
        static void Main(string[] args)
        {
            // Provide directory name with complete location.  
            DirectoryInfo directory = new DirectoryInfo(@"E:\BIZZZ\FileIO\directory");
            try
            {
                // Check, directory exist or not.  
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }
                // Creating a new directory.  
                directory.Create();
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }
        }
    }
}
