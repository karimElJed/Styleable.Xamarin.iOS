using System;
using System.ComponentModel;
using Foundation;
using UIKit;

namespace Styleable.Xamarin.iOS.TestApp
{
    [Register("StylableView")]
    [DesignTimeVisible(true)]
    [Category("Styleable")]
    public class StylableView : UIView, IRootView
    {
        //todo: rename to StylableRootView
        private static IStylesheet _stylesheet;

        public IStylesheet Stylesheet
        {
            get => _stylesheet ?? (_stylesheet = new TestStylesheet());
            set => _stylesheet = value;
        }

        public StylableView(IntPtr ptr) : base(ptr)
        {
        }
    }    
}