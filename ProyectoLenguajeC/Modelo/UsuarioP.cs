using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLenguajeC.Modelo
{
    public class UsuarioP
    {
        public UsuarioP(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }

        public string Nombre{ get; set; }


        public string Password { get; set; }
        public string Email { get; set; }

        public string Telefono { get; set; }

    }
}
