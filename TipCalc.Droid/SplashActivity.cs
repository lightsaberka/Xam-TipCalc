using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;

namespace TipCalc.Droid
{
	[Activity(Label = "TipCalc.Droid", MainLauncher = true, NoHistory = true)]
	public class SplashActivity : MvxSplashScreenActivity
	{
		public SplashActivity(): base(Resource.Layout.splash) { }
	}
}