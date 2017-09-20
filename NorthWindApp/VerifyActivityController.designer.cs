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

namespace NorthWindApp
{
    [Register ("VerifyActivityController")]
    partial class VerifyActivityController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnVerificar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCorreo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPass { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnVerificar != null) {
                btnVerificar.Dispose ();
                btnVerificar = null;
            }

            if (txtCorreo != null) {
                txtCorreo.Dispose ();
                txtCorreo = null;
            }

            if (txtPass != null) {
                txtPass.Dispose ();
                txtPass = null;
            }
        }
    }
}