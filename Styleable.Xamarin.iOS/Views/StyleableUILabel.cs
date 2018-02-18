using System;
using System.ComponentModel;
using Foundation;

namespace Styleable.Xamarin.iOS.Views
{
    [Register("StyleableUILabel")]
    [Category("Styleable")]
    [DesignTimeVisible(true)]
    public class StyleableUILabel : UIKit.UILabel, IStyleable
    {
        [Export("Style"), Browsable(true), DisplayName("Style")]
        public string StyleName { get; set; }

        public StyleableUILabel(IntPtr ptr) : base(ptr)
        {
            
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            this.ApplyStyles(StyleName);            
        }       
    }
}