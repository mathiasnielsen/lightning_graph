using Xamarin.Forms;

namespace LightningGraph
{
    public partial class LightningGraphPage : ContentPage
    {
        public LightningGraphPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var charts = DummyData.CreateXamarinSample();
            this.chart1.Chart = charts[0];
            this.chart2.Chart = charts[1];
        }
    }
}
