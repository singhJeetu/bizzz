﻿using System;
namespace CSharpProgram
{
    class ExSystemExCl
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 25;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}