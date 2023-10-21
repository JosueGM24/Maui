namespace temperatura
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            unity.SelectedIndex = 0;
            toConvert.SelectedItem = 0;
        }
        private static double KelvinToCelcius(double kelvin)
        {
            double result = kelvin - 273.15;
            return result;
        }

        private double FarenheidToCelsius(double farenheid)
        {
            double result = (farenheid - 32) * (5 / 9);
            return result;
        }

        private static double CelsiusToFarenheid(double celsius)
        {
            double result =  celsius * (9 / 5) + 32;
            return result;
        }

        private static double FarenheidToKelvin(double farenheid)
        {
            double result =  (farenheid - 32) * (5 / 9) + 273.15;
            return result;

        }
        private static double CelsiusToKelvin(double celsius)
        {
            double result =  celsius + 273.15;
            return result;
        }

        async void BtnConvertir_Clicked(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(grades.Text);
            string title = unity.SelectedItem + " a " + toConvert.SelectedItem;
            if (unity.SelectedIndex == 0)
            {
                if (unity.SelectedIndex == toConvert.SelectedIndex)
                {
                    await DisplayAlert(title, numero + "°C", "OK");

                }
                else if (toConvert.SelectedIndex == 1)
                {
                    await DisplayAlert(title,CelsiusToFarenheid(numero).ToString(),"OK");
                } else
                {
                    await DisplayAlert(title,CelsiusToKelvin(numero).ToString(), "OK");
                }
            }
            else if (unity.SelectedIndex == 1)
            {
                if (unity.SelectedIndex == toConvert.SelectedIndex)
                {
                    await DisplayAlert(title, numero + "°F", "OK");

                }
                else if (toConvert.SelectedIndex == 0)
                {
                    await DisplayAlert(title, FarenheidToCelsius(numero).ToString(), "OK");
                }
                else
                {
                    await DisplayAlert(title, FarenheidToKelvin(numero) + "", "OK");
                }
            }
            else
            {
                if (unity.SelectedIndex == toConvert.SelectedIndex)
                {
                    await DisplayAlert(title, numero + "°K", "OK");

                }
                else if (toConvert.SelectedIndex == 0)
                {
                    await DisplayAlert(title, KelvinToCelcius(numero) + "", "OK");
                }
                else
                {
                    await DisplayAlert(title, CelsiusToFarenheid(KelvinToCelcius(numero)) + "", "OK");
                }
            }
        }


    }
}