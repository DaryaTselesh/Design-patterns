using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PatternStructure
{
	public class ConcreteBuilderB : Builder
	{
		#region Private Members

		private readonly Product product = null;

		#endregion

		#region Constructors

		public ConcreteBuilderB()
		{
			this.product = new Product();
		}

		#endregion

		public override void BuildFirstPart()
		{
			this.product.Composition += "First part b\n";
		}

		public override void BuildSecondPart()
		{
			this.product.Composition += "Second part b\n";
		}

		public override void BuildThirdPart()
		{
			this.product.Composition += "Third part b\n";
		}

		public override Product GetResult()
		{
			return this.product;
		}
	}
}
