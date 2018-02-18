using UIKit;

namespace Styleable.Xamarin.iOS
{
    public interface IStyleable
    {
        string StyleName { get; set; }

        UIView Superview { get; }
    }
}