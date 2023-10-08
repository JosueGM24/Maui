
namespace MauiApp7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcularFactorial_Clicked(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(numeroFactorial.Text);
                numero = Math.Abs(numero);
                numeroFactorial.Text = numero.ToString();
                    int resultado = numero;
                    for(int x = (numero - 1);x > 0; x--)
                    {
                        resultado *= x;
                    }
                    lblResultadoFactorial.Text = resultado.ToString();
            } catch(Exception excep)
            {
                lblResultadoFactorial.Text = "Ingresa un número correcto";
            }
        }

        private void btnCalcularPotencia_Clicked(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(numeroPotenciacion.Text);
                int numeroPotenciaint = Convert.ToInt32(numeroPotencia.Text);
                int signo = Math.Abs(numeroPotenciaint);
                double resultado = numero;
                while (signo > 1)
                {
                    resultado *= numero;
                    signo--;
                }
                if (numeroPotenciaint < 0)
                {
                    lblResultadoPotencia.Text = (1 / resultado).ToString();
                }
                else
                {
                    lblResultadoPotencia.Text = resultado.ToString();
                }

            } catch (Exception excep)
            {
                lblResultadoPotencia.Text = "Ingresa numeros correctos";
            }
        }

        private void btnCalcularFibonacci_Clicked(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(numeroFibonacci.Text);
                numero = Math.Abs(numero);
                numeroFibonacci.Text = numero.ToString();
                int a =1, b =1, c;
                string resultado = "1 ,1";
                for (int x = 2; x < numero; x++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    resultado = resultado + " ," + c;
                }
                lblResultadoFibonacci.Text = resultado.ToString();
            }
            catch (Exception excep)
            {
                lblResultadoFibonacci.Text = "Ingresa numeros correctos";
            }
        }

        private void btnCalcularEcuacion_Clicked(object sender, EventArgs e)
        {
            int aV = Convert.ToInt32(a.Text);
            int bV = Convert.ToInt32(b.Text);
            int cV = Convert.ToInt32(c.Text);
            double x1 = 0, x2 = 0;
            double discriminante = (bV * bV) - (4 * aV * cV);
            if (discriminante > 0) {
                x1 = ((bV * -1) + Math.Sqrt(discriminante)) / (2 * aV);
                x2 = ((bV * -1) - Math.Sqrt(discriminante)) / (2 * aV);
                lblX1.Text = "X1: " + x1;
                lblX2.Text = "x2: " + x2;
            } else
            {
                x1 = (bV * -1) / (2 * aV);
                double x11 = Math.Sqrt((discriminante * -1)) / (2 * aV);
                x2 = (bV * -1) / (2 * aV);
                double x22 = Math.Sqrt((discriminante * -1)) / (2 * aV);
                lblX1.Text = "X1: " + x1 + " + " + x11 + "i";
                lblX2.Text = "x2: " + x2 + " - " + x22 + "i";
            }
        }
    }
}