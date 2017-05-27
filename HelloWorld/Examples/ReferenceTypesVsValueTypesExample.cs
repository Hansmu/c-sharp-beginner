using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Examples
{
	class ReferenceTypesVsValueTypesExample
	{
		public static void UsageExample()
		{
			var a = 10;
			var b = a;
			b++;    //	Integers are value types. So a copy is created and declared at the target location, so a remains 10 even if you increment b.

			Console.WriteLine(string.Format("a: {0},  b: {1}", a, b));

			var array1 = new int[3] { 1, 2, 3 };
			var array2 = array1;
			array2[0] = 0;  //	

			Console.WriteLine(string.Format("array1[0]: {0}, array2[0], {1}", array1[0], array2[0]));
		}
	}
}
