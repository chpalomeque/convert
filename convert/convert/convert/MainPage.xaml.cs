using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace convert
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ConvertButton.Clicked += ConvertButton_Clicked; 
        }

        private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ConvertEntry.Text))
            {
                DisplayAlert("Error", "You must enter a value in celsius. ", "Accept");
                return;
            }

            decimal celsius = 0;
            if (decimal.TryParse(ConvertEntry.Text, out celsius))
            {


                decimal a = 1.8M;
                decimal b = 32;

                var fahrenheit = celsius * a + b;

                FahrenheitEntry.Text = string.Format("{0:N}", fahrenheit);

            }
            else { DisplayAlert("Error", "You must enter a value numeric in celsius. ", "Accept"); }
        }
    }
}
