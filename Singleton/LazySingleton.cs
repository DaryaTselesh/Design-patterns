using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class LazySingleton
	{
		protected LazySingleton()
		{
		}

		public static LazySingleton GetInstance()
		{
			return Nested.instance;
		}

		private class Nested
		{
			//What is the reason to use internal instead of public in this case?
			internal static readonly LazySingleton instance = new LazySingleton();
		}
	}
}
