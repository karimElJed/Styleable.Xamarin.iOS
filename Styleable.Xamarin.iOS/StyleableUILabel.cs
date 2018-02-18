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
            //todo: implement a generic extension?
            if (String.IsNullOrWhiteSpace(StyleName))  return;

            UIView parent = this.Superview;
            while (parent != null && !(parent is IRootView))
            {
                parent = parent.Superview;
            }

            IStylesheet stylesheet = null;
            if (parent is IRootView root)
            {
                stylesheet = root.Stylesheet;
            }

            if (stylesheet == null) return;

            //todo: refactor
            //todo: performance?

            IStyle<IStyleable> style;
            stylesheet.Styles.TryGetValue(StyleName, out style);

            var uiStyle = style as Style<StyleableUILabel>;

            if (uiStyle == null) return;
            
            foreach (var styling in uiStyle.Stylings) 
            {
                styling(this);
            }
        }        
    }
}