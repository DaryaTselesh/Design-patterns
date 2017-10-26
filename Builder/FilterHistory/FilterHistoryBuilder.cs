using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FilterHistory
{
	public class FilterHistoryBuilder
	{
		private FilterHistory filterHistory = null;

		public FilterHistoryBuilder()
		{
			this.filterHistory = new FilterHistory();
		}

		public void AddName(string name)
		{
			this.filterHistory.Name = name;
		}

		public void AddCompanies()
		{
			this.filterHistory.Companies = new List<string>()
			{
				"The first company",
				"The second company"
			};
		}

		public void AddDepartments()
		{
			this.filterHistory.Departments = new List<string>()
			{
				"The first department",
				"The second department"
			};
		}

		public void AddEmployees()
		{
			this.filterHistory.Employees = new List<string>()
			{
				"The first employee",
				"The second employee"
			};
		}

		public FilterHistory GetFilterHistory()
		{
			return this.filterHistory;
		}
	}
}
