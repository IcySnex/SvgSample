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
            ((Style)dic["DefaultCustomElementStyle"]).Setters.Add(new Setter(CustomElement.IconProperty, Helpers.ToImageSource(Helpers.SampleSvg, 64, 64)));
        }
    }
}
