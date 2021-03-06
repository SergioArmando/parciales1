using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7
{
    public partial class MainPage : ContentPage
    {
   
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Dato.Text))
            {
                var nresultado = Int32.Parse(Dato.Text);
                var resultado = nresultado - 365;
                string Nresultado = resultado.ToString();

                if (nresultado <= 0)
                {
                    Nresultado = "Numero invalido";
                }
                await DisplayAlert("RESPUESTA", Nresultado, "si");
            }
            else
            {
                await DisplayAlert("Alerta", "No escribe la informacion", "ok");
            }

        }

    }
}
