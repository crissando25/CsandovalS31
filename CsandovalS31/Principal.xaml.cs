using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CsandovalS31
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                //colocar una variable double con la conversion de string a double

                double DatoUno = Convert.ToDouble(txtdatoUno.Text) * 0.3;
                double DatoDos = Convert.ToDouble(txtdatodos.Text) * 0.2;
                double suma = DatoUno + DatoDos;
                TxtResultado.Text = suma.ToString();

                double Datotres = Convert.ToDouble(txtdatoUno.Text) * 0.3;
                double Datocuatro = Convert.ToDouble(txtdatodos.Text) * 0.2;
                double suma1 = DatoUno + DatoDos;

                txtResultado2.Text = suma.ToString();

                double NOtaFinal = suma + suma1;
                double N0taFinal = Convert.ToDouble(txtfinal.Text);

                if (N0taFinal >= 7)
                {
                    DisplayAlert("NOTAS ESTADO", "Tu calificacion" + N0taFinal + "\nAprobaste con" + NOtaFinal, "CERRAR");
                }
                else
                 if (NOtaFinal >= 5 && NOtaFinal <= 6.9)
                {
                    DisplayAlert("NOTAS ESTADO", "Tu calificacion" + N0taFinal + "\nComplementario con" + NOtaFinal, "CERRAR");
                }
                else
                if (NOtaFinal >= 5 && NOtaFinal < 5)
                {
                    DisplayAlert("NOTAS ESTADO", "Tu calificacion " + N0taFinal + "\nReprobaste con" + NOtaFinal, "CERRAR");
                }
            }


            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias por su atencion");
            }


        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            //limpiar todos los datos de la pantalla

            txtName.Text = "";
            txtdatoUno.Text = "";
            txtdatodos.Text = "";
            txtDatotres.Text = "";
            txtDatocuatro.Text = "";
            TxtResultado.Text = "";
            txtResultado2.Text = "";

        }
    }
}