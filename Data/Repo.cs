using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
	class Repo
	{
		private List<Configuration> configurations = new List<Configuration>
			{
			new Configuration("CFG1"),
			new Configuration("CFG2"),
			new Configuration("CFG3"),
			new Configuration("CFG4"),
			new Configuration("Bober")
			};

		internal List<Configuration> GetListOfConfig()
		{
			return configurations;
		}

		internal void DeleteConfig(string name)
		{
			configurations.RemoveAll(x => x.Name.Equals(name));
		}
	}
}
