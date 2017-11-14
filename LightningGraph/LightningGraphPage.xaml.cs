using System.Threading.Tasks;
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

            InitiateDataLoad();
        }

        private async void InitiateDataLoad()
        {
            await Task.Delay(1000);

            InitiateFlash();

            var charts = DummyData.CreateXamarinSample();
            this.chart1.Chart = charts[0];
            this.chart2.Chart = charts[1];
        }

        private async void InitiateFlash()
        {
            FlashView.IsVisible = true;
            FlashView.IsEnabled = false;
            FlashView.Opacity = 1;

            await FlashView.FadeTo(0, 1000, null);

            Device.BeginInvokeOnMainThread(() => FlashView.IsVisible = false);
        }
    }
}
