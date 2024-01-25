using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_PrimitivesTypes
{
    internal class DString
    {
        static void Run(string[] args)
        {
            var firstName = "Maria";
            var lastName = "Nascimento";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Maria" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
            Look into the the following paths
            c:\folder1\folder2
            c:\folder3\folder4";

            Console.WriteLine(text);

        }


    }
}
