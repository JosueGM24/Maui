using Microsoft.Maui.Controls.Platform;

namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        //private void btnMessage_Clicked(object sender, EventArgs e)
        //{
        //    string message = entryMessage.Text;
        //    lblMessage.Text = "Tu mensaje es " + message;
        //    SemanticScreenReader.Announce("SpartaAa!!");
        //}

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNum1.Text);
            int numero2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = "resultado = " + (numero1 + numero2).ToString();
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResult.Text = "Sin resultados :)";

        }

        private void btnRestar_Clicked(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNum1Resta.Text);
            int numero2 = Convert.ToInt32(txtNum2Resta.Text);
            lblResultResta.Text = "resultado = " + (numero1 - numero2).ToString();
        }


        private void btnDividir_Clicked(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNum1D.Text);
            int numero2 = Convert.ToInt32(txtNum2D.Text);
            if (numero2 <= 0)
            {
                lblResultDividir.Text = "No se puede entre 0 :(";
            } else
            {
                lblResultDividir.Text = "resultado = " + (numero1 / numero2).ToString();
            }
        }


        private void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNum1M.Text);
            int numero2 = Convert.ToInt32(txtNum2M.Text);
            lblResultMulti.Text = "resultado = " + (numero1 * numero2).ToString();
            
        }

        private void btnLimpiarDividir_Clicked(object sender, EventArgs e)
        {
            txtNum2D.Text = "";
            txtNum1D.Text = "";
            lblResultDividir.Text = "Sin resultados :)";
        }

        private void btnLimpiarMulti_Clicked(object sender, EventArgs e)
        {
            txtNum1M.Text = "";
            txtNum2M.Text = "";
            lblResultMulti.Text = "Sin resultados :)";
        }

        private void btnLimpiarResta_Clicked(object sender, EventArgs e)
        {
            txtNum1Resta.Text = "";
            txtNum2Resta.Text = "";
            lblResultResta.Text = "Sin resultados :)";
        }
    }
}