using Foundation;
using System;
using UIKit;

namespace Phoneword_iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            string translateNumber = "";

            TranslateButton.TouchUpInside += (Object sender, EventArgs e) =>
            {
                translateNumber = PhoneTranslator.ToNumber(PhoneNumberText.Text);
            
                PhoneNumberText.ResignFirstResponder();

                if ( translateNumber == "")
                {
                    CallButton.SetTitle("Llamar ", UIControlState.Normal);
                    CallButton.Enabled = false;
                }
                else
                 {
                    CallButton.SetTitle("Call " + translateNumber, UIControlState.Normal);
                    CallButton.Enabled = true;
                }
            };

            //Boton de llamada
            CallButton.TouchUpInside += (Object sender, EventArgs e) =>
            {
                var url = new NSUrl("TEL:" + translateNumber);

                if (!UIApplication.SharedApplication.OpenUrl(url))
                {
                    var alert = UIAlertController.Create("No Soportado", "Scheme 'tel:' no esta soportado en este dispositivo", UIAlertControllerStyle.Alert);
                    alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

                    PresentViewController(alert, true, null);
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