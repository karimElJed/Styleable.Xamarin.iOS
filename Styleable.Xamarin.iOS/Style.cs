using System;
using System.Collections.Generic;

namespace Styleable.Xamarin.iOS
{
    //todo: document
    public class Style<TView> : IStyle<TView> where TView : IStyleable
    {
        public List<Action<TView>> Stylings { get; }

        public Style(List<Action<TView>> styleDefinitions)
        {
            Stylings = styleDefinitions;
        }        
    }
}