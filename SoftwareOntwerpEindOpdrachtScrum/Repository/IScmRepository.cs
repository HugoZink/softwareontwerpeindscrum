using SoftwareOntwerpEindOpdrachtScrum.Scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Repository
{
	public interface IScmRepository
	{
		IEnumerable<Branch> Branches { get; }

		Branch GetBranch(string name);

		void SaveBranch(Branch branch);

		void DeleteBranch(Branch branch);
	}
}
