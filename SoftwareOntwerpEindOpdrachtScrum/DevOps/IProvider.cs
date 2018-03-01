using SoftwareOntwerpEindOpdrachtScrum.Scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.DevOps
{
	public interface IProvider
	{
		void Execute(Branch branch);
	}
}
