using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto001
{
    internal class Container
    {
        ///Atributos clase Container
        private String codigo;
        private String marca;
        private int capacidadMaxima;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;
        private Buque buque;

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Container()
        {
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        public Container(string codigo, string marca, int capacidadMaxima, byte tamaño, bool esRefrigerado, int pesoActual, Buque buque)
        {
            this.Codigo = codigo;
            this.Marca = marca;
            this.CapacidadMaxima = capacidadMaxima;
            this.Tamaño = tamaño;
            this.EsRefrigerado = esRefrigerado;
            this.PesoActual = pesoActual;
            this.Buque = buque;
        }

        /// <summary>
        /// Metodos Getter y Setter para cada atributo
        /// </summary>
        public string Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public byte Tamaño { get => tamaño; set => tamaño = value; }
        public bool EsRefrigerado { get => esRefrigerado; set => esRefrigerado = value; }
        public int PesoActual { get => pesoActual; set => pesoActual = value; }
        internal Buque Buque { get => buque; set => buque = value; }

        public override string ToString()
        {
            return "Container: " + Codigo + " " + Marca + " " + CapacidadMaxima + " " + Tamaño + " " + EsRefrigerado + " " + PesoActual + "" + Buque;
        }

        public void ReglaPesoActual()
        {
            if (PesoActual > 0 && PesoActual < capacidadMaxima)
            {
                Console.WriteLine("El peso actual del Container es el correcto");
            }
            else
            {
                Console.WriteLine("El peso actual debe ser mayor a 0 y no puede superar la capacidad máxima de carga");
            }
        }

        public void SacarPeso()
        {
            int Pesofinal;
            Pesofinal = pesoActual - 10;
            Console.WriteLine("El peso final del container corresponde a: " + Pesofinal);
        }

        public void ValorPagoInspeccion()
        {

        }


        public void PuedeSubir()
        {
            bool permitidosubido;
            permitidosubido = true;
        }

    }
}
