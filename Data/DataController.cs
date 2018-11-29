using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
	public class DataController
	{
		private Repo repo;

		public DataController()
		{
			repo = new Repo();
		}

		public List<Configuration> GetListOfConfig()
		{
			List<Configuration> l = repo.GetListOfConfig();
			return l;
		}

		public void Delete(string name)
		{
			repo.DeleteConfig(name);
		}
	}
}