using System;
using NorthWindModel;
using UIKit;

namespace NorthWindApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			NorthWindModelClass model = new NorthWindModelClass();
            model.ChangeStatus += (sender, e) => 
            {
                string status;
                switch(e.Status)
                {
                    case NorthWind.StatusOptions.CallingWebAPI:
                        status = "Llamando a la WebAPI";
                        break;
                    case NorthWind.StatusOptions.ProductFound:
                        status = "Producto encontrado";
                        break;
                    case NorthWind.StatusOptions.ProductNotFound:
                        status = "Producto no encontrado";
                        break;
                    case NorthWind.StatusOptions.VerifyingResult:
                        status = "Verificando resultado";
                        break;
                    default:
                        status = "Estado";
                        break;
                }
                lblStatus.Text = status;
            };

			btnBuscar.TouchUpInside += async (sender, e) => 
            {
                int id = int.Parse(txtFieldID.Text);
                var product = await model.GetProductByIDAsync(id);
                if(product != null)
                {
					txtNombre.Text = product.ProductName;
					txtPrecio.Text = product.UnitPrice.ToString();
					txtExistencia.Text = product.UnitsInStock.ToString();
					txtCategoria.Text = product.CategoryID.ToString();
                }
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
