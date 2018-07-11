// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TipCalc.iOS.Views
{
    [Register ("TipView")]
    partial class TipView
    {
        [Outlet]
        UIKit.UISlider generosity_bar { get; set; }


        [Outlet]
        UIKit.UITextField subtotal_edit { get; set; }


        [Outlet]
        UIKit.UILabel tip_result { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (generosity_bar != null) {
                generosity_bar.Dispose ();
                generosity_bar = null;
            }

            if (subtotal_edit != null) {
                subtotal_edit.Dispose ();
                subtotal_edit = null;
            }

            if (tip_result != null) {
                tip_result.Dispose ();
                tip_result = null;
            }
        }
    }
}