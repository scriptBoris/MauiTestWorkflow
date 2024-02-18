namespace MauiTestWorkflow
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

#if DEVELOP
            DisplayAlert("MSG", "DEVELOP mode", "OK");
#endif

#if DEBUG
            DisplayAlert("MSG", "DEBUG mode", "OK");
#endif

#if ANDROID
            DisplayAlert("MSG", "ANDROID mode", "OK");
#endif

#if NET8_0_OR_GREATER
            DisplayAlert("MSG", "NET8> mode", "OK");
#endif

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
