using System;
using CapaLogicas;
using CapasdeDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejemplocapas
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionUsuario gestionusuario = new GestionUsuario();
            gestionusuario.Usuario = new Usuario()
            {
                Identificacion = "13047862316",
                Nombre = "Pedro",
                Clave = "2482"
            };
            gestionusuario.InsertarUsuario();

            gestionusuario.Usuario = new Usuario()
            {
                Identificacion = "13045862316",
                Nombre = "Pablo",
                Clave = "8482546546464"
            };
           
            gestionusuario.Usuario = new Usuario()
            {
                Identificacion = "13045862316",
                Nombre = "Eckerd",
                Clave = "45616546465465465"
            };
            gestionusuario.InsertarUsuario();
            foreach (Usuario item in gestionusuario.ListaUsuarios())
            {
                Console.WriteLine(item.Nombre);
               
            }
            try
            {
                gestionusuario.EliminarUsuario();
            }
            catch (Exception Ex)
            {

                Console.WriteLine(Ex.Message) ;
            }
            

            foreach (Usuario item in gestionusuario.ListaUsuarios())
            {
                Console.WriteLine(item.Nombre);
               
            }

           
            
            gestionusuario.EliminarUsuario();
            //Console.WriteLine(gestionusuario.IndividualUsuario("13045862316").Nombre);

            Console.ReadKey();
            }
        }
    }

