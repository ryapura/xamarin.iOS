using Foundation;
using System;
using UIKit;

namespace basic.Controls
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

            //eventos para el Boton 1
            btn1.TouchUpInside += (sender, e) =>
            {
                //aqui creamos la alerta
                var messageBox = UIAlertController.Create( "Titulo", "Click desde btn1" ,UIAlertControllerStyle.Alert);
                //agregamos la accion
                messageBox.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                //lo presentamos
                PresentViewController(messageBox, true, null);

            };

            // para el boton 2
            btn2.TouchUpInside += (sender, e) =>
            {
                var messageBox = UIAlertController.Create("Titulo 2 opciones", "msj con modal 2 acciones", UIAlertControllerStyle.Alert);
                messageBox.AddAction(UIAlertAction.Create("Aceptar", UIAlertActionStyle.Default, alert => Console.WriteLine("Aceptar 2 opciones")));
                messageBox.AddAction(UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, alert => Console.WriteLine("Cancelar 2 opciones")));

                PresentViewController(messageBox, true, null);

            };

            // para el boton 3
            btn3.TouchUpInside += Btn3_TouchUpInside;
        }

        private void Btn3_TouchUpInside(object sender, EventArgs e)
        {
            //Creamos nuestra Alerta
            UIAlertController messageBox = UIAlertController.Create("Titulo Btn3", "Selecciones un item de abajo", UIAlertControllerStyle.ActionSheet);
            //Agregamos las acciones
            messageBox.AddAction(UIAlertAction.Create("Gano", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item uno")));
            messageBox.AddAction(UIAlertAction.Create("Empato", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item dos")));
            messageBox.AddAction(UIAlertAction.Create("Perdio", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Item tres")));

            UIPopoverPresentationController presentationPopover = messageBox.PopoverPresentationController;
            if (presentationPopover != null )
            {
                presentationPopover.SourceView = this.View;
                presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;

            }
            this.PresentViewController(messageBox, true, null);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}