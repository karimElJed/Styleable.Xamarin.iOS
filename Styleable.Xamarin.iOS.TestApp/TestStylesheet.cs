using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Styleable.Xamarin.iOS.TestApp
{
    
   public class TestStylesheet : IStylesheet
    {
        private class Colors
        {
            public static UIColor Orange = new UIColor(1.0f, 1f, 0f, 1f);
        }

        public Dictionary<string, IStyle<IStyleable>> Styles { get; private set; }

        public TestStylesheet()
        {
            Initialize();
        }

        private void Initialize()
        {
            Styles = new Dictionary<string, IStyle<IStyleable>>();

            Styles.Add("defaultLabel", new Style<StyleableUILabel>
            {
                Stylings = new List<Action<StyleableUILabel>>
                {
                    l => l.BackgroundColor = Colors.Orange,
                    l => l.TextColor = UIColor.Cyan,
                    l => l.Text = "Hallo",                    
                }
            });

            Styles.Add("redLabel", new Style<StyleableUILabel>
            {
                
            });

            //todo: add possibility to inherit styles
            //Styles.Add("nondefaultLabel", new Style<IStyleable>(Styles["defaultLabel"])
            //{
            //    //...
            //});
        }
    }
}