// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace NorthWindApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBuscar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnVerificar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblStatus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCategoria { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtExistencia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtFieldID { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPrecio { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnBuscar != null) {
                btnBuscar.Dispose ();
                btnBuscar = null;
            }

            if (btnVerificar != null) {
                btnVerificar.Dispose ();
                btnVerificar = null;
            }

            if (lblStatus != null) {
                lblStatus.Dispose ();
                lblStatus = null;
            }

            if (txtCategoria != null) {
                txtCategoria.Dispose ();
                txtCategoria = null;
            }

            if (txtExistencia != null) {
                txtExistencia.Dispose ();
                txtExistencia = null;
            }

            if (txtFieldID != null) {
                txtFieldID.Dispose ();
                txtFieldID = null;
            }

            if (txtNombre != null) {
                txtNombre.Dispose ();
                txtNombre = null;
            }

            if (txtPrecio != null) {
                txtPrecio.Dispose ();
                txtPrecio = null;
            }
        }
    }
}