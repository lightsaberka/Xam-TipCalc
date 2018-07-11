using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using TipCalc.Core.ViewModels;
using UIKit;

namespace TipCalc.iOS.Views
{
    public partial class TipView : MvxViewController
    {
        public TipView() : base(nameof(TipView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<TipView, TipViewModel>();

            set.Bind(subtotal_edit).To(x => x.SubTotal);
            set.Bind(generosity_bar).To(x => x.Generosity);
            set.Bind(tip_result).To(x => x.Tip);

            set.Apply();

            // hide the keyboard when tapped somewhere else
            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                this.subtotal_edit.ResignFirstResponder();
            }));
        }
    }
}