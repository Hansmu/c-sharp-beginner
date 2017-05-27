using System;
// Have access to all the classes that are within one namespace. In order to use one from another namespace, then you need to use "using" to import.

namespace HelloWorld
{
	public class Person
	{
		private string firstName;
		private string lastName;

		public Person(string firstName, string lastName)
		{
			this.firstName = firstName;
			this.lastName = lastName;
		}

		public void Introduce()
		{
			Console.WriteLine("Hello, I'm {0} {1}", firstName, lastName);
		}
	}
}
