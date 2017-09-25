using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PatternStructure
{
	public abstract class Builder
	{
		#region Methods

		public virtual void BuildFirstPart() { }

		public virtual void BuildSecondPart() { }

		public virtual void BuildThirdPart() { }

		public abstract Product GetResult();

		#endregion
	}
}
