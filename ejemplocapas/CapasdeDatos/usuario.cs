using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasdeDatos
{
    public class Usuario
    {
        private String  identificacion;

        public String  Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String clave;

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }

    }
}
