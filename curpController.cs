
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace MauiApp8
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            string[] entidades = new string[] {
    "Aguascalientes",
    "Baja California",
    "Baja California Sur",
    "Campeche",
    "Chiapas",
    "Chihuahua",
    "Coahuila",
    "Colima",
    "Distrito Federal",
    "Durango",
    "Guanajuato",
    "Guerrero",
    "Hidalgo",
    "Jalisco",
    "Estado de Mexico",
    "Michoacan",
    "Morelos",
    "Nayarit",
    "Nuevo Leon",
    "Oaxaca",
    "Puebla",
    "Queretaro",
    "Quintana Roo",
    "San Luis Potosi",
    "Sinaloa",
    "Sonora",
    "Tabasco",
    "Tamaulipas",
    "Tlaxcala",
    "Veracruz",
    "Yucatan",
    "Zacatecas",
    "Nacido en el extranjero"};
            
            foreach (string estado in entidades) {
                entidad.Items.Add(estado);
            }

        }

        async void BtnGenerarCurp_Clicked(object sender, EventArgs e)

        {
            string nombre = nombrePersona.Text;
            string apellidoP = apellidoPaterno.Text;
            string apellidoM = apellidoMaterno.Text;
            while (nombre == null || nombre.Length == 0)
            {
                nombre = await DisplayPromptAsync("Error en datos", "Ingresa un nombre correcto");
                nombrePersona.Text = nombre;
            }
            while (apellidoP == null || apellidoP.Length == 0)
            {
                apellidoP = await DisplayPromptAsync("Error en datos", "Ingresa tu apellido paterno");
                apellidoPaterno.Text = apellidoP;
            }
            while (apellidoM == null || apellidoM.Length == 0)
            {
                apellidoM = await DisplayPromptAsync("Error en datos", "Ingresa tu apellido materno");
                apellidoMaterno.Text = apellidoM;
            }
            if (entidad.SelectedItem == null)
            {
                await DisplayAlert("Selecciona un estado", "Estado incorrecto", "Corregir");
                entidad.Focus();
            }
            else if (!hom.IsChecked && !muj.IsChecked)
            {
                await DisplayAlert("Selecciona un estado", "Estado incorrecto", "Corregir");
                hom.Focus();
            }
            else
            {
                string[] acotaciones = new string[] {
    "AS",
    "BC",
    "BS",
    "CC",
    "CS",
    "CH",
    "CL",
    "CM",
    "DF",
    "DG",
    "GT",
    "GR",
    "HG",
    "JC",
    "MC",
    "MN",
    "MS",
    "NT",
    "NL",
    "OC",
    "PL",
    "QT",
    "QR",
    "SP",
    "SL",
    "SR",
    "TC",
    "TS",
    "TL",
    "VZ",
    "YN",
    "ZN",
    "NE"};
                string curp = apellidoP[..2].ToUpper() +
                    apellidoM[..1].ToUpper() +
                    nombre[..1].ToUpper() +
                    fechaNacimiento.Date.ToString("yyMMdd") + (hom.IsChecked ? "H" : "M") +
                    acotaciones[entidad.SelectedIndex] +
                    SecondConsonant(apellidoP) +
                    SecondConsonant(apellidoM) +
                    SecondConsonant(nombre) +
                    GetRandomcharacter() +
                    GetRandomcharacter();
                await DisplayAlert("Curp", curp, "OK");
            }
        }

        static string GetRandomcharacter()
        {

            Random rnd = new();
            int test = rnd.Next(4);
            if (test >= 2)
            {
                Random rdn = new();
                return rdn.Next(9) + "";
            } else
            {
                Random rdn = new();
                return Convert.ToChar(rdn.Next(65,90)).ToString();
            }
        }

        static string SecondConsonant (String sentence)
        {
            string consonant = "";
            foreach (char a in sentence.ToLower()[..1])
            {
                if (a != 'a' && a != 'e' && a != 'i' && a != 'o' && a != 'u')
                {
                    consonant =  a.ToString();
                    break;
                }
            }
            return consonant.ToUpper();
        }
    }
}9