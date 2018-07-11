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
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.Droid.Views
{
	[Activity(Label = "TipCalc.Droid")]
	class TipView : MvxActivity<TipViewModel>
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.tipview);

			this.InitBinding();
		}

		private void InitBinding()
		{
			var set = this.CreateBindingSet<TipView, TipViewModel>();

			set.Bind(this.FindViewById<EditText>(Resource.Id.subtotal_edit)).To(x => x.SubTotal);
			set.Bind(this.FindViewById<SeekBar>(Resource.Id.generosity_bar)).To(x => x.Generosity);
			set.Bind(this.FindViewById<TextView>(Resource.Id.tip_result)).To(x => x.Tip);

			set.Apply();
		}

	}
}
