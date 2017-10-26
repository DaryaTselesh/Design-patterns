using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FilterHistory
{
	public class FilterHistoryService : IFilterHistoryService
	{
		public FilterHistory GetCommonFilterHistory(string name)
		{
			FilterHistoryBuilder builder = new FilterHistoryBuilder();
			builder.AddName(name);
			builder.AddCompanies();
			builder.AddDepartments();

			return builder.GetFilterHistory();
		}

		public FilterHistory GetFilterHistory(string name, int maxCount = 10)
		{
			FilterHistoryBuilder builder = new FilterHistoryBuilder();
			builder.AddName(name);
			builder.AddCompanies();
			builder.AddDepartments();
			builder.AddEmployees();

			return builder.GetFilterHistory();
		}
	}
}
