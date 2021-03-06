﻿using SoftwareOntwerpEindOpdrachtScrum.Scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.DevOps
{
	public class Build : IAction
	{
		public void Execute(Branch branch)
		{
			ActionProviderFactory.Instance.GetProvider<Build>().Execute(branch);
		}

		public string GetResults()
		{
			return "Success";
		}
	}
}
