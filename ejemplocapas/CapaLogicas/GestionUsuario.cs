using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapasdeDatos;

namespace CapaLogicas
{
    public class GestionUsuario
    {
        CapasdeDatos.UsuariosCRUD Gu;
        public GestionUsuario()
        {
            Gu = new UsuariosCRUD();
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public void InsertarUsuario()
        {
            Gu.Usuario = this.Usuario;
            if (this.Usuario.Clave.Length <= 10)
            {
                throw new Exception("LA CLAVE DEBE TENER MINIMO 10 CARACTERES");
            }

            Gu.InsertarUsuario();
        }
        public List<Usuario> ListaUsuarios()
        {
            return Gu.ListaDeUsuario();
        }
        public Usuario IndividualUsuario(string identificacion)
        {
            return Gu.IndividualUsuario(identificacion);
        }
        public void EliminarUsuario()
        {
         
            Gu.EliminarUsuario();
        }
        public void ModificarUsuario()
        {
            
            Gu.ModificarUsuario();
        }
           
        }
}
