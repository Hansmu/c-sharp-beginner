using System;
using HelloWorld.Examples;
using HelloWorld.Math;
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

			Console.WriteLine("\nTYPE CONVERSION EXAMPLE");
			TypeConversionExample();

			Console.WriteLine("\nOPERATORS EXAMPLE");
			OperatorsExample();

			var person = new Person("John", "Smith");
			person.Introduce();

			Calculator calculator = new Calculator();
			Console.WriteLine(calculator.Add(10, 10));

			StringAndArrayExamples.UsageExamples();
			ReferenceTypesVsValueTypesExample.UsageExample();
		}

		private static void TypeConversionExample()
		{
			byte b = 1;
			int i = b;

			Console.WriteLine(i);

			byte reverse = (byte)i;
		
			Console.WriteLine(reverse);

			var number = "1234";
			int convertString = Convert.ToInt32(number);
			convertString = int.Parse(number);

			Console.WriteLine(number);

			try
			{
				byte bait = Convert.ToByte(number);
				Console.WriteLine(bait);
			}
			catch (Exception)
			{
				Console.WriteLine("Conversion went wrong.");
			}
		}

		private static void OperatorsExample()
		{
			// Same as Java.
			int numberOne = 1;
			int numberTwo = 2;
			string result = numberOne < numberTwo ? "Number two is greater" : "Number one is greater or equal.";

			Console.WriteLine((float)numberOne / numberTwo);
			Console.WriteLine(numberOne == numberTwo);
		}
	}
}
