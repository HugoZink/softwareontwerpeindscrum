using SoftwareOntwerpEindOpdrachtScrum.Scrum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Repository
{
	public interface IUserRepository
	{
		IEnumerable<User> Users { get; }

		User GetUser(string name);

		void SaveUser(User user);

		void DeleteUser(User user);
	}
}
