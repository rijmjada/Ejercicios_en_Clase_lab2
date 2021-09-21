using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._07_9_21
{
    public class Pluma
    {

        #region Atributos

        private string marca;
        private Tinta tinta;
        private int cantidad;

        #endregion

        #region Constructores

        public Pluma()
        {
            this.marca = "Sin Marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string _marca) :this()
        {
            this.marca = _marca;
        }

        public Pluma(string _marca, Tinta _tinta) :this(_marca)
        {
            this.tinta = _tinta;
        }

        public Pluma(string _marca, Tinta _tinta, int _cantidad) :this(_marca, _tinta)
        {
            this.cantidad = _cantidad;
        }

        #endregion

        #region Metodos de Instancia

        private string Mostrar()
        {
            return  "\nMarca: " + this.marca + 
                    "\nTinta: " + (string) this.tinta +  
                    "\nCantidad: " + this.cantidad.ToString();
        }

        #endregion

        #region Sobrecarga de Operadores
        /// <summary>
        /// Compara la tinta de una Pluma con alguna Tinta 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> True si la tinta de la pluma es igual a la tinta B</returns>
        public static bool operator ==(Pluma a, Tinta b)
        {
            return a.tinta == b;
        }

        public static bool operator !=(Pluma a , Tinta b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Agrega tinta a una pluma solo si sus tintas son iguales (incrementar cantidad)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Pluma operator +(Pluma a, Tinta b)
        {
            if(a == b)
            {
                a.cantidad++;
            }
            return a;
        }

        
        /// <summary>
        /// Decrementa la cantidad de tinta de una Pluma, si la tinta de la pluma y la tinta son iguales (decrementar cantidad)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Pluma operator -(Pluma a, Tinta b)
        {
            if (a == b)
            {
                a.cantidad--;
            }
            return a;
        }

        public static implicit operator string(Pluma a)
        {
            return a.Mostrar();
        }

        #endregion



    }
}
