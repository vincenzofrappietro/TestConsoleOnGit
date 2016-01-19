using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleOnGit
{
	class Infrastructure
	{
		public void Initialize()
		{
			int max = 0;

			for (int i = 0; i < max; i++)
				Console.WriteLine(string.Format("Initializing part {0} of {1}", i+1, max));
		}
	}
}
