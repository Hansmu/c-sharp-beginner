using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Examples
{
	class StringAndArrayExamples
	{
		public static void UsageExamples()
		{
			var numbers = new int[3];
			numbers[0] = 1;
			var flags = new bool[3];
			var names = new string[3] { "Jack", "John", "Mary" };
			var initializedNumbers = new int[3] { 1, 2, 3 };

			string name = "Bob " + " Mary";
			string usingFormatter = string.Format("{0} {1}", "John", "Smith");
			string list = string.Join(",", initializedNumbers);

			// Can create variables in several ways. Ex. string could be declared with var, String, string.
			var firstName = "Randy";
			var lastName = "Marsh";
			var fullName = string.Format("My name is: {0} {1}", firstName, lastName);

			var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
			var formattedVerbatim = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";

			Console.WriteLine(fullName);
			Console.WriteLine(list);
			Console.WriteLine(string.Join(",", names));
			Console.WriteLine(text);
			Console.WriteLine(formattedVerbatim);
		}
	}
}
