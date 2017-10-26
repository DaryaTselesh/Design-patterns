using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FilterHistory
{
	public interface IFilterHistoryService
	{
		FilterHistory GetFilterHistory(string name, int maxCount = 10);

		FilterHistory GetCommonFilterHistory(string name);
	}
}
