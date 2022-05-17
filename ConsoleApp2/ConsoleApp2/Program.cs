using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "welcome@to-qa-with-experts#.com";
			var test = "my name is chanaka";
            string replacestr = Regex.Replace(str, "[^a-zA-Z0-9_]+", " ");
            Console.WriteLine(replacestr);
            Console.ReadLine();
        }
    }
}
