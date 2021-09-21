using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._07_9_21
{
    public class Tinta
    {

        #region Atributos

        private ConsoleColor color;
        private ETipoTinta tipo;

        #endregion

        #region Constructores


        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }


        public Tinta(ConsoleColor _color) : this()
        {
            this.color = _color;
        }

     
        public Tinta(ConsoleColor _color, ETipoTinta _tipo) : this(_color)
        {
            this.tipo = _tipo;
        }



        #endregion

        #region Metodos de Instancia

        private string Mostrar()
        {
            return "Tipo: " + this.tipo.ToString() + "\nColor: " + this.color.ToString();
        }

        #endregion

        #region Metodos de Clase

        public static string Mostrar(Tinta unaTinta)
        {
            return unaTinta.Mostrar();
        }

        #endregion

        #region Sobrecargas de Operadores

        public static explicit operator string(Tinta a)
        {
            return a.Mostrar();
        }

        public static bool operator ==(Tinta a, Tinta b)
        {
            return a.tipo == b.tipo && a.color == b.color;
        }

        public static bool operator !=(Tinta a, Tinta b)
        {
            return !(a == b);
        }

        #endregion


    }
}
