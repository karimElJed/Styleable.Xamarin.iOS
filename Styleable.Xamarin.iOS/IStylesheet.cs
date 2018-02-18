using System.Collections.Generic;

namespace Styleable.Xamarin.iOS
{
    //todo: document
    public interface IStylesheet
    {        
        Dictionary<string, IStyle<IStyleable>> Styles { get; }       
    }
}
