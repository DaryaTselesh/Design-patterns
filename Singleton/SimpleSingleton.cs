using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class SimpleSingleton
	{
		private static SimpleSingleton instance;

		protected SimpleSingleton()
		{
		}

		public static SimpleSingleton GetInstance()
		{
			if (instance == null)
			{
				instance = new SimpleSingleton();
			}

			return instance;
		}
	}
}
