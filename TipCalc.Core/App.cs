using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross;
using MvvmCross.ViewModels;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;

namespace TipCalc.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			Mvx.RegisterType<ICalcService, CalcService>();

			RegisterAppStart<TipViewModel>();
		}
	}
}
