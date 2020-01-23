using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasdeDatos
{
    public class UsuariosCRUD
    {
        public UsuariosCRUD()
        {

        }

        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public void InsertarUsuario()
        {
            Singleton.Instancia.Usuarios.Add(Usuario);//se cambiara a una base de datos
        }

             public List<Usuario> ListaDeUsuario()
        {
              return Singleton.Instancia.Usuarios;
        }

        public Usuario IndividualUsuario(string identificacion)
        {
            return Singleton.Instancia.Usuarios.Find(g=>g.Identificacion==identificacion);
        }

        public void EliminarUsuario()
        {
            Singleton.Instancia.Usuarios.Remove(IndividualUsuario(Usuario.Identificacion));
        }

        public void ModificarUsuario()
        {
            Usuario usuarioaModificar=IndividualUsuario(usuario.Identificacion);
            usuarioaModificar.Nombre = Usuario.Nombre;
            usuarioaModificar.Clave = Usuario.Clave;

        }
    }
}
