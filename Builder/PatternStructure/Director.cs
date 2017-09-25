using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PatternStructure
{
	public class Director
	{
		#region Public Methods

		public Product Construct(Builder builder)
		{
			builder.BuildFirstPart();
			builder.BuildSecondPart();
			builder.BuildThirdPart();

			return builder.GetResult();
		}

		#endregion
	}
}
