using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Telefono
    {
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        public Telefono (string modelo, string marca)
        {
            this.Modelo = modelo;
            this.Marca = marca;
        }

        public string Modelo { get; }

        public string Marca { get; set; }

        public int NumeroTelefonico { get; set; }

        public int CodigoOperador
        {
            get { return codigoOperador; }

            set
            {
                if (value>0 && value <4)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".

        public string Llamar ()
        {
           
            return "Realizando llamada...";
        }
        //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        public string Llamar (string personaje)
        {
            return "Llamando a " + personaje;

        }



    }
}
