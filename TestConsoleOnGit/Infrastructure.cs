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

			Console.WriteLine("Please wait...");

			for (int i = 0; i < max; i++)
				Console.WriteLine(string.Format("Starting up part {0} of {1}", i+1, max));

			Console.WriteLine("Completed");
		}
	}
}
