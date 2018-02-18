using System;
using System.Collections.Generic;
using UIKit;

namespace Styleable.Xamarin.iOS
{
    //todo: document
    public class Style<TView> : IStyle<TView> where TView : IStyleable
    {
        public List<Action<TView>> Stylings { get; set; }
    }
}