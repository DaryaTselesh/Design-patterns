using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PatternStructure
{
	public class Product
	{
		public string Composition { get; set; } = string.Empty;

		public override string ToString()
		{
			return this.Composition;
		}
	}
}
