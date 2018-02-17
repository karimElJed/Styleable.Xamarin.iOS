using System;
using System.Collections.Generic;
using UIKit;

namespace Styleable.Xamarin.iOS
{
    //move to test app project
    public class TestStylesheet : IStylesheet
    {
        public Dictionary<string, IStyle<IStyleable>> Styles { get; }

        public TestStylesheet()
        {
            Styles= new Dictionary<string, IStyle<IStyleable>>();

            Styles.Add("defaultLabel", new Style<StyleableUILabel>
            {
                Stylings = new List<Action<StyleableUILabel>>
                {
                    l => l.BackgroundColor = UIColor.Blue,
                    l => l.TextColor = UIColor.White
                }                
            });

            //todo: add possibility to inherit styles
            //Styles.Add("nondefaultLabel", new Style<IStyleable>(Styles["defaultLabel"])
            //{
            //    //...
            //});
        }
            
        

        
    }
}