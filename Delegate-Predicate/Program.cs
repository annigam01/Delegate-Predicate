using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //5th Syntax - using Predicate - this is just a boolean returning function
            Predicate<string> IsSuperman = x => x == "Superman"; // this will return true of supplied string is eq Superman

            List<string> Names = new List<string>();

            Names.Add("Superman");
            Names.Add("Spiderman");
            Names.Add("Batman");

            var myname = Names.Find(IsSuperman); // you can use predicate here to filter a collection
            Console.WriteLine(myname);

            //Console.WriteLine(CA(3));
            Console.Read();

        }
    }
}
