using System;
namespace AccessSpecifiers
{
    class EncaptulationEx
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            // Setting values to the properties 

            company.ID = "101";
            company.Name = "Bizruntime";
            company.Email = "bizruntime.com";

            // getting values  

            Console.WriteLine("ID = " + company.ID);
            Console.WriteLine("Name = " + company.Name);
            Console.WriteLine("Email = " + company.Email);
        }
    }
}