﻿using UIKit;

namespace Styleable.Xamarin.iOS.TestApp
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            StyleManager.SetActiveStylesheet(new TestStylesheet());

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}