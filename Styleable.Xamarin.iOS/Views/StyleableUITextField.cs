using System;
using System.ComponentModel;
using System.Drawing;

using CoreGraphics;
using Foundation;
using UIKit;

namespace Styleable.Xamarin.iOS.Views
{
    [Register("StyleableUITextField")]
    [Category("Styleable")]
    [DesignTimeVisible(true)]
    public class StyleableUITextField : UITextField, IStyleable
    {
        [Export("Style"), Browsable(true), DisplayName("Style")]
        public string StyleName { get; set; }

        public StyleableUITextField()
        {
        }

        public StyleableUITextField(IntPtr ptr) : base(ptr)
        {
        }

        public StyleableUITextField(RectangleF bounds) : base(bounds)
        {
            
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            this.ApplyStyles(StyleName);
        }        
    }
}