using ClassLibrary1;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Class1 class1 = new Class1();

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
            
            int result = class1.getValue10(count);

            CounterLabelCalc.Text = $"Using IImcCalc on a dll library: {result}";

        }
    }
}