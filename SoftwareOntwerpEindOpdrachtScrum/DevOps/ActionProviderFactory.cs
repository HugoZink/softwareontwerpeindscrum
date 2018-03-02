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

		private Dictionary<Type, IProvider> _providers;

		private ActionProviderFactory()
		{
			this._providers = new Dictionary<Type, IProvider>();
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

		public IProvider GetProvider<T>() where T: IAction
		{
			return this._providers[typeof(T)];
		}

		public void RegisterProvider<T>(IProvider provider) where T : IAction
		{
			this._providers.Add(typeof(T), provider);
		}
	}
}
