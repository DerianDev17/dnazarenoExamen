using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dnazarenoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "usuario conectado" + " " + "Es" + " " + usuario;
            this.usuario = usuario;
        }

        private void btResumen_Clicked(object sender, EventArgs e)
        {
            
            string nombre = Convert.ToString(txNombre.Text);
            string apellido = Convert.ToString(txtApellido.Text);
            double edad = Convert.ToDouble(txtEdad.Text);
            string Fechas = dpFechas.Date.ToString("M/d/yyyy");
            string pais = pkPais.Items[pkPais.SelectedIndex];
            string cuidad = pkCiudad.Items[pkCiudad.SelectedIndex];
            double monto = Convert.ToDouble(txtMonto.Text);
            double pago = Convert.ToDouble(txtPago.Text);
            double btPago = Convert.ToDouble(txtPago.Text);

            Navigation.PushAsync(new Resumen(usuario,nombre,apellido,edad,Fechas,pais,cuidad,monto,pago, btPago));
        }

        private void btPago_Clicked(object sender, EventArgs e)
        {
            var montoI = double.Parse(txtMonto.Text);
            var mensualI = 1800 - montoI;
            var mensualC = mensualI / 3;
            var mensualF = mensualC * 1.05;



            string MensajeCal = "Su cuota mensual es de: " + mensualF + " por 3 meses";

            DisplayAlert("Calculo de cuota:", MensajeCal, "Aceptar .");
        }

        private void pkPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pkPais.SelectedIndex == -1)
            {
                DisplayAlert("Seleccion de pais", "nulo", "salir");
            }
            else
            {
                DisplayAlert("Pais Seleccionado", pkPais.Items[pkPais.SelectedIndex], "Cerrar");
            }

        }

        private void pkCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pkCiudad.SelectedIndex == -1)
            {
                DisplayAlert("Seleccion de Ciudad", "nulo", "salir");
            }
            else
            {
                DisplayAlert("Ciudad Seleccionada", pkCiudad.Items[pkCiudad.SelectedIndex], "Cerrar");
            }

        }
    }
}