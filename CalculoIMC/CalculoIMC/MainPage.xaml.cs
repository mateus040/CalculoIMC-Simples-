using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculoIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txt_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);

            double imc = peso / (altura * altura);

            string msg = "Seu IMC é: " + Math.Round(imc,2);

            DisplayAlert("Resultado", msg, "OK");


        }
    }
}
