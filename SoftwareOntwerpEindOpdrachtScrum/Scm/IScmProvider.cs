using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scm
{
	public interface IScmProvider
	{
		void Merge(Branch mainBranch, Branch branchToMerge);

		void Sync(Branch branch);
	}
}
