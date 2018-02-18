using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Styleable.Xamarin.iOS.TestApp
{
    public partial class MyTestViewController : UIViewController
    {
        public MyTestViewController() : base("MyTestViewController", null)
        {
            
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
    
}