using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace parcial_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            var numero = double.Parse(Texto);
            var result = ((numero / 5) - 8) / 2;
            number.text = result.ToString();

            string resultado = "";
            if (numero == 0) 
            {
                resultado = "el numero ingresado no valido";

            }
            else
            {

                   
            }
        }

    }
}    

