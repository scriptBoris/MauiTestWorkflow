namespace MauiTestWorkflow
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

#if DEVELOP
            await DisplayAlert("MSG", "DEVELOP mode", "OK");
#elif PROD
            await DisplayAlert("MSG", "PRODUCTION mode", "OK");
#endif

#if DEBUG
            await DisplayAlert("MSG", "DEBUG mode", "OK");
#endif

            await DisplayAlert("MSG", 
                $"version:{DeviceInfo.Version}\n" + 
                $"version string: {DeviceInfo.VersionString}",
                "OK");


            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            // test
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
