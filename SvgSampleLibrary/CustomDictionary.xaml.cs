using Windows.UI.Xaml;

namespace SvgSampleLibrary
{
    public partial class CustomDictionary : ResourceDictionary
    {
        public CustomDictionary()
        {
            InitializeComponent();

            LoadIcon(this);
        }


        public static void LoadIcon(
            ResourceDictionary dic)
        {
            // Loading from file (WORKS):
            //((Style)dic["DefaultCustomElementStyle"]).Setters.Add(new Setter(CustomElement.IconProperty, Helpers.FromAssets("ms-appx:///Assets/sample.svg", 64, 64)));

            // Loading from memory (DOESNT WORK):
            ((Style)dic["DefaultCustomElementStyle"]).Setters.Add(new Setter(CustomElement.IconProperty, Helpers.ToImageSource(Helpers.SampleSvg, 64, 64)));
        }
    }
}
