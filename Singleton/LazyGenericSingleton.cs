using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class LazyGenericSingleton
	{
		private static readonly Lazy<LazyGenericSingleton> lazy = new Lazy<LazyGenericSingleton>(() => new LazyGenericSingleton());

		protected LazyGenericSingleton()
		{
		}

		public LazyGenericSingleton GetInstance()
		{
			return lazy.Value;
		}
	}
}
