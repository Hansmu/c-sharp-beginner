using System;
// Have access to all the classes that are within one namespace. In order to use one from another namespace, then you need to use "using" to import.

namespace HelloWorld
{
	class Program
	{
		// Main is the entry point of the application. Case sensitive.
		static void Main(string[] args)
		{
			const float Pi = 3.14f;

			byte number = 10;
			int count = 10;
			float totalPrice = 20.95f; //Without the f, then the number is treated as a double.
			char character = 'A';
			string firstName = "Banana";
			bool isWorking = true;
			//var can be used to allow C# to decide the type.
			var numberDynamic = 10;

			Console.WriteLine(number);
			Console.WriteLine("Hello world");
			Console.WriteLine(count);
			Console.WriteLine("{0} {1}", 10, 11);
		}
	}
}
