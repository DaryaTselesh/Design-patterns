using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PatternStructure
{
	public class ConcreteBuilderA : Builder
	{
		#region Private Members

		private readonly Product product = null;

		#endregion

		#region Constructors

		public ConcreteBuilderA()
		{
			this.product = new Product();
		}

		#endregion

		public override void BuildFirstPart()
		{
			this.product.Composition += "First part a\n";
		}

		public override Product GetResult()
		{
			return this.product;
		}
	}
}
