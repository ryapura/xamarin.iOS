// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace basic.Controls
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn3 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btn1 != null) {
                btn1.Dispose ();
                btn1 = null;
            }

            if (btn2 != null) {
                btn2.Dispose ();
                btn2 = null;
            }

            if (btn3 != null) {
                btn3.Dispose ();
                btn3 = null;
            }
        }
    }
}