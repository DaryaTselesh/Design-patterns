using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FilterHistory
{
	public class FilterHistory
	{
		public IEnumerable<string> Companies { get; set; }

		public IEnumerable<string> Departments { get; set; }

		public IEnumerable<string> Employees { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
