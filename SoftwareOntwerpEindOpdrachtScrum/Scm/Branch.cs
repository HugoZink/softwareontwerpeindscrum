using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scm
{
	public class Branch
	{
		public string Name { get; set; }

		public List<Commit> Commits { get; set; }

		public Branch()
		{
			this.Commits = new List<Commit>();
		}

		public void Merge(Branch branch)
		{
			throw new NotImplementedException();
		}

		public void Commit(Commit commit)
		{
			this.Commits.Add(commit);
		}

		public void Sync()
		{
			ScmProviderFactory.Instance.GetProvider().Sync(this);
		}
	}
}
