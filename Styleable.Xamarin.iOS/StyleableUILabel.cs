using System.ComponentModel;
using CoreGraphics;
using Foundation;

namespace Styleable.Xamarin.iOS
{
    [DesignTimeVisible(true)]
    public class StyleableUILabel : UIKit.UILabel, IStyleable
    {
        private string _style;
        [Export("Style")]
        public string StyleName
        {
            get => _style;
            set
            {
                _style = value;
                ApplyStyles();
            }
        }

        private void ApplyStyles()
        {
            //todo: implement a generic extension?
            var stylesheet = StyleManager.Stylesheet;

            Style<StyleableUILabel> style = stylesheet.Styles[StyleName] as Style<StyleableUILabel>;

            if (style == null) return;

            foreach (var styling in style.Stylings) 
            {
                styling(this);
            }
        }        
    }
}