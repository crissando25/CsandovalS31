using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CsandovalS31
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            
        }
        
        //}

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            if (usuario == "cris" && contraseña == "1988")
            {
                Navigation.PushAsync(new Principal());
            }
            else
            {
                Navigation.PushAsync(new Registrar());
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrecto", "Cerrar");
            }
        }
        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registrar());
        }
        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtUsuario.Text=" ";
            txtContraseña.Text =" ";
        }

        //    private void txtdatos_TextChanged(object sender, TextChangedEventArgs  e)
        //    {
        //        try
        //        {
        //            double numero = Convert.ToDouble(txtdatos.Text); 
        //            if(numero < 1 && numero > 10)
        //            {
        //                DisplayAlert("MENSAJE", "El rango permitido es 1-10", "Cerrar");
        //                txtdatos.Text = "";

        //            }
        //        }
        //        catch(Exception ex)
        //        {
        //            DisplayAlert("ERROR", ex.Message, "Cerrar");

        //        }
        //}
        //}
    }
}
