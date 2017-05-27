using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Examples
{
	// Enum is a new type, so have to declare it on the namespace level.
	// By default if you don't provide values, then the first one is set to 0 and every other is incremented by one.
	public enum ShippingMethod
	{
		RegularAirMail = 1,
		RegisteredAirMail = 2,
		Express = 3
	}

	class EnumExample
	{
		public static void UseageExample()
		{
			var method = ShippingMethod.Express;

			var methodId = 3;
			Console.WriteLine((ShippingMethod)methodId);

			var methodName = "Express";
			// Parse a string - turn it into a different type.
			var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
		}
	}
}
