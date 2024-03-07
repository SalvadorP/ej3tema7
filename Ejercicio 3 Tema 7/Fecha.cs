using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Tema_7
{
    internal class Fecha {
        //Miembros
        public int d;
        public int m;
        public int a;


        //Constructor
        public Fecha() {
            d = -1;
            m = -1;
            a = -1;
        }

        //Métodos
        //Función año bisiesto --> private
        private bool bisiesto(int anyo)         {
            bool bisiesto = false;

            if (anyo % 4 == 0 && anyo % 100 != 0) {
                bisiesto = true;
            }
            if (anyo % 4 == 0 && anyo % 400 == 0) {
                bisiesto = true;
            }
            return bisiesto;
        }

        //Función FechaValida --> private
        private bool fechaValida(int anyo, int mes, int dia, bool bisiesto) {
            bool valida = false;
            bool diaCorrecto = false;
            bool mesCorrecto = mes > 0 && mes <= 12;
            bool mes30 = mes == 4 || mes == 6 || mes == 9 || mes == 11;
            bool mes31 = mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12;

            if (mes30 == true) {
                diaCorrecto = dia > 0 && dia <= 30;
            }
            if (mes == 2) {
                diaCorrecto = dia > 0 && dia <= 28;
                if (bisiesto(anyo) == true) {
                    diaCorrecto = dia > 0 && dia <= 29;
                }
            }
            if (mes31 == true) {
                diaCorrecto = dia > 0 && dia <= 31;
            }
            if (anyo >= 0 ) {
                if (anyo <= 2024) {
                    if (mesCorrecto) {
                        if (diaCorrecto) {
                            valida = true;
                        }
                    }
                }
            }
            return valida;
        }

        //Función para dar valor a los miembros, en función de si la fecha es válida o no.
        //Hacemos esto en lugar de la propiedad set.
        public bool darValores(int dia, int mes, int anyo)
        {
            bool correcta = fechaValida(dia, mes, anyo);
            if (correcta) {
                d = dia;
                m = mes;
                a = anyo;
            }
            return correcta; //Si la fecha es incorrecta, devuelve false y no añade
                             //nuevos valores a los miembros.
        }

        //Función para mostrar fechas (string)
        public string mostrarFecha() {
            return d + " / " + m + " / " + a;
        }
    }
}
