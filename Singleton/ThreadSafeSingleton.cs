using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class ThreadSafeSingleton
	{
		private static ThreadSafeSingleton instance;
		private static object syncLock = new object();

		protected ThreadSafeSingleton()
		{
		}

		public static ThreadSafeSingleton GetInstance()
		{
			if (instance == null)
			{
				lock (syncLock)
				{
					instance = new ThreadSafeSingleton();
				}
			}

			return instance;
		}
	}
}
