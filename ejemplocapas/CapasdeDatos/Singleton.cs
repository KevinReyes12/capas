using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasdeDatos
{
    public sealed class Singleton
    {
        //La clase singleton es nuestra base de datos
        protected Singleton()
        {
            this.Usuarios = new List<Usuario>();
        }
        private static Singleton instancia;

        public static Singleton Instancia
        {
           
            get
            {
                if (instancia==null)
                {
                    instancia = new Singleton();
                }
                return instancia;
            }
        }
        private List<Usuario> usuarios;

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

    }
}
