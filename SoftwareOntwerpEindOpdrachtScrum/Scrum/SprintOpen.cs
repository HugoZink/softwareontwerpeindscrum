﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	public class SprintOpen : SprintState
	{
		public override bool CanEdit
		{
			get
			{
				return true;
			}
		}

		public override SprintState Start()
		{
			return new SprintInProgress();
		}
	}
}
