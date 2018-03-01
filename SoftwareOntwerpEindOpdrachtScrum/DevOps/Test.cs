using SoftwareOntwerpEindOpdrachtScrum.Scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.DevOps
{
	class Test : IAction
	{
		public void Execute(Branch branch)
		{
			ActionProviderFactory.Instance.GetProvider(this).Execute(branch);
		}

		public string GetResults()
		{
			return "Success";
		}
	}
}
