namespace Styleable.Xamarin.iOS
{
    //todo: document
    //might allow switching styles on the fly!?!
    public static class StyleManager
    {
        //todo: make thread safe or constrain to app startup
        private static IStylesheet _activeStyle;

        public static IStylesheet Stylesheet => _activeStyle;

        public static void SetActiveStylesheet(IStylesheet stylesheet)
        {
            _activeStyle = stylesheet;
        }
    }
}