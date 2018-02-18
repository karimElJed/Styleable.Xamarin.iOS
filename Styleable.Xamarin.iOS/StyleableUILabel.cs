using System;
using System.ComponentModel;
using System.Reflection;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Styleable.Xamarin.iOS
{
    [Register("StyleableUILabel"), DesignTimeVisible(true)]
    [Category("Styleable")]
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
            ApplyStyles();
        }
        

        private void ApplyStyles()
        {
            var member = this.GetType().GetProperty("BackgroundColor");
            member?.SetValue(this, UIColor.Green);

            //todo: implement a generic extension?
            var stylesheet = StyleManager.Stylesheet;

            if (stylesheet == null) return;


            IStyle<IStyleable> style;
            stylesheet.Styles.TryGetValue(StyleName, out style);

            var uiStyle = style as Style<StyleableUILabel>;

            if (uiStyle == null) return;
            
            uiStyle.SetColor(this);
            foreach (var styling in uiStyle.Stylings) 
            {
                //styling(this);                
            }
        }        
    }
}