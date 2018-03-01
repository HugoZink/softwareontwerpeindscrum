using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.DevOps
{
	public class ActionProviderFactory
	{
		private static ActionProviderFactory instance;

		private ServiceContainer _providers;

		private ActionProviderFactory()
		{
			this._providers = new ServiceContainer();
		}

		public static ActionProviderFactory Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ActionProviderFactory();
				}

				return instance;
			}
		}

		public IProvider GetProvider(IAction action)
		{
			return this._providers.GetService(action.GetType()) as IProvider;
		}

		public void RegisterProvider<T>(IProvider provider) where T : IAction
		{
			this._providers.AddService(typeof(T), provider);
		}
	}
}
