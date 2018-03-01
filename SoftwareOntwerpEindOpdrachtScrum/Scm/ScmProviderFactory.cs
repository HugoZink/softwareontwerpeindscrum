using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scm
{
	public class ScmProviderFactory
	{
		private static ScmProviderFactory instance;

		private ServiceContainer _providers;

		private ScmProviderFactory()
		{
			this._providers = new ServiceContainer();
		}

		public static ScmProviderFactory Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ScmProviderFactory();
				}

				return instance;
			}
		}

		public IScmProvider GetProvider()
		{
			return this._providers.GetService(typeof(IScmProvider)) as IScmProvider;
		}

		public void RegisterProvider(IScmProvider provider)
		{
			this._providers.AddService(typeof(IScmProvider), provider);
		}
	}
}
