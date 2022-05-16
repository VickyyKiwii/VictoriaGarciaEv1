using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    internal class Buque
    {
        ///Atributos clase Buque
        private String codigo;
        private int MinLenght = 5;
        private String nombre;
        private String pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        List<Container> listaContainers;

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Buque()
        {
        }

        /// <summary>
        ///Constructor con parametros
        /// </summary>
        public Buque(string codigo, string nombre, string pais, int cantidadContainers, int cantidadContainersCargados, int gastoTransporte, List<Container> listaContainers)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Pais = pais;
            this.CantidadContainers = cantidadContainers;
            this.CantidadContainersCargados = cantidadContainersCargados;
            this.GastoTransporte = gastoTransporte;
            this.ListaContainers = listaContainers;
        }

        /// <summary>
        /// Métodos Getter y Setter
        /// </summary>
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int CantidadContainers { get => cantidadContainers; set => cantidadContainers = value; }
        public int CantidadContainersCargados { get => cantidadContainersCargados; set => cantidadContainersCargados = value; }
        public int GastoTransporte { get => gastoTransporte; set => gastoTransporte = value; }
        internal List<Container> ListaContainers { get => listaContainers; set => listaContainers = value; }

        /// <summary>
        /// Metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Buque: " + Codigo + " " + Nombre + " " + Pais + " " + CantidadContainers + " " + CantidadContainersCargados + " " + GastoTransporte;
        }

        public void CantCodigo()
        {

            if (Codigo.Length < 5)
            {

                Console.WriteLine("Codigo debe ser igual o mayor a 5 caracteres");

            }
            else
            {
                return;
            }
        }



        public void SubirContainer()
        {
            if CantidadContainer(){

            }
            {

            }
        }

    }
}
    

