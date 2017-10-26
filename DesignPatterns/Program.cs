using Builder.FilterHistory;
using Builder.PatternStructure;
using System;
using static System.Console;

namespace DesignPatterns
{
	public struct SomeStruct
	{
		public int x;

		public int y;

		public string name;

		public SomeStruct(int x) : this()
		{
			this.x = x;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();

			switch(command)
			{
				case "1":
					Console.WriteLine("Builder example with films");

					Director director = new Director();
					Console.WriteLine(director.Construct(new ConcreteBuilderA()));
					Console.WriteLine(director.Construct(new ConcreteBuilderB()));

					break;
				case "2":
					Console.WriteLine("Builder example with filter history");

					FilterHistoryService service = new FilterHistoryService();
					Console.WriteLine(service.GetFilterHistory("My filter history"));
					Console.WriteLine(service.GetCommonFilterHistory("My common filter history"));

					break;
			}
			

			Console.ReadLine();
		}
	}
}
