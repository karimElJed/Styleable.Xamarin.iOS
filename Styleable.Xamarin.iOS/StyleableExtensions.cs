using System;
using UIKit;

namespace Styleable.Xamarin.iOS
{
    public static class StyleableExtensions
    {
        public static void ApplyStyles<TView>(this TView view, string styleName) where TView: IStyleable
        {            
            if (String.IsNullOrWhiteSpace(styleName)) return;

            UIView parent = view.Superview;
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
            stylesheet.Styles.TryGetValue(styleName, out style);

            var uiStyle = style as Style<TView>;

            if (uiStyle == null) return;

            foreach (var styling in uiStyle.Stylings)
            {
                styling(view);
            }
        }
    }
}
