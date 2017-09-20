using Foundation;
using System;
using UIKit;
using System.Threading.Tasks;

namespace NorthWindApp
{
    public partial class VerifyActivityController : UIViewController
    {
        public VerifyActivityController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            btnVerificar.TouchUpInside += async  (sender, e) => { await ValidateActivity(); };
        }

        private async Task ValidateActivity()
        {
            var client = new SALLab07.ServiceClient();
            var result = await client.ValidateAsync(txtCorreo.Text, txtPass.Text, new NorthWindModel.NorthWindModelClass());

            var Alert = UIAlertController.Create("Resultado", $"{result.Status} {result.FullName} {result.Token}", UIAlertControllerStyle.Alert);
            Alert.AddAction(UIAlertAction.Create("OK!", UIAlertActionStyle.Default, null));
            PresentViewController(Alert, true, null);
        }
    }
}