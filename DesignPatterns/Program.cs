using Builder.PatternStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			Director director = new Director();

			Console.WriteLine(director.Construct(new ConcreteBuilderA()));
			Console.WriteLine(director.Construct(new ConcreteBuilderB()));

			Console.ReadLine();
		}
	}
}
