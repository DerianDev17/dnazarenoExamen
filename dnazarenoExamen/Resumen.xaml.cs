using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dnazarenoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string apellido, double edad, string Fechas, string pais, string cuidad, double monto, double pago, double btPago)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado" + usuario;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEdad.Text = edad.ToString();
            txtFecha.Text = Fechas.ToString();
            txtPais.Text = pais.ToString();
            txtCuidad.Text = cuidad.ToString();
            txtMonto.Text = monto.ToString();
            txtPago.Text = pago.ToString();
            btPago.ToString();
         

        }
    }
}