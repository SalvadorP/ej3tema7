using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_Tema_7
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        List<Fecha> listaFechas = new List<Fecha>();

        // Función que devuelve cierto si la fecha1 es más moderna que la fecha 2
        bool fechaMasModerna( Fecha fecha1, Fecha fecha2) {
            bool moderner = false;
            bool anyoModerner = fecha1.Anyo > fecha2.Anyo;
            bool mesModerner = fecha1.Anyo == fecha2.Anyo && fecha1.Mes > fecha2.Mes;
            bool diaModerner = fecha1.Anyo == fecha2.Anyo && fecha1.Mes == fecha2.Mes && fecha1.Dia > fecha2.Dia;

            if (anyoModerner || mesModerner || diaModerner) {
                moderner = true;
            }
            return moderner;
        }

        private void leerBtn_Click(object sender, EventArgs e) {
            resultadoLabel.Text = "";

            Fecha fecha = new Fecha();

            int dia = int.Parse(Interaction.InputBox("Introduzca el día:", "Ejercicio 3"));
            int mes = int.Parse(Interaction.InputBox("Introduzca el mes:", "Ejercicio 3"));
            int anyo = int.Parse(Interaction.InputBox("Introduzca el año:", "Ejercicio 3"));

            bool correcta = fecha.darValores(dia, mes, anyo);//función que devuelve false
                                                             //si fecha incorrecta
            if (correcta) {
                listaFechas.Add(fecha);
            } else {
                MessageBox.Show("La fecha introducida es incorrecta.");
            }

        }

        private void ordenarBtn_Click(object sender, EventArgs e) {
            Fecha aux;

            for (int i = 0; i < listaFechas.Count - 1; i++) {
                for (int j = i + 1; j < listaFechas.Count; j++) {
                    if (fechaMasModerna(listaFechas[i], listaFechas[j])) {
                        aux = listaFechas[i];
                        listaFechas[i] = listaFechas[j];
                        listaFechas[j] = aux;
                    }
                }
            }
        }

        private void listarBtn_Click(object sender, EventArgs e)
        {
            string texto = "La lista de fechas es:\n";
            foreach (Fecha fecha in listaFechas) {
                texto += fecha.mostrarFecha() + "\n";
            }

            resultadoLabel.Text = texto;
        }
    }
}
