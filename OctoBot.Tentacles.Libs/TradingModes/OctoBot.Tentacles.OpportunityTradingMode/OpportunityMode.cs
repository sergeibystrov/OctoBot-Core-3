﻿using System;
using System.Diagnostics;
using OctoBot.Tradings;

namespace OctoBot.Tentacles
{
	public class OpportunityMode : AbstractTradingMode
	{
		public OpportunityMode()
		{
			Debug.WriteLine(1);
		}

		protected override void CreateCreators(object symbol, object symbol_evaluator)
		{
			throw new NotImplementedException();
		}

		protected override void CreateDeciders(object symbol, object symbol_evaluator)
		{
			throw new NotImplementedException();
		}
	}
}