using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public class Thread
	{
		public string Title { get; set; }

		public string Content { get; set; }

		public List<Post> Posts { get; private set; }

		public Thread()
		{
			this.Posts = new List<Post>();
		}
	}
}
