using SoftwareOntwerpEindOpdrachtScrum.Scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.DevOps
{
	public class Deploy : IAction
	{
		public void Execute(Branch branch)
		{
			ActionProviderFactory.Instance.GetProvider<Deploy>().Execute(branch);
		}

		public string GetResults()
		{
			return "Success";
		}
	}
}
