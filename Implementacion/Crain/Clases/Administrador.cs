using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Administrador
    {
        private int idAdministrador;
        private int nombreAdministrador;
        private int apellidoAdministrador;
        private int usuarioAdministrador;
        private int passwordAdministrador;
        private int cargoAdministrador;

        public int IdAdministrador
        {
            get
            {
               return idAdministrador;
            }
            set
            {
                idAdministrador = value;
            }
        }

        public int NombreAdministrador
        {
            get
            {
                return nombreAdministrador;
            }
            set
            {
                nombreAdministrador = value;
            }
        }

        public int ApellidoAdministrador
        {
            get
            {
                return apellidoAdministrador;
            }
            set             
            {
                apellidoAdministrador = value;
            }
        }

        public int UsuarioAdministrador
        {
            get
            {
                return usuarioAdministrador;
            }
            set
            {
                usuarioAdministrador = value;
            }
        }

        public int PasswordAdministrador
        {
            get
            {
                return passwordAdministrador;
            }
            set
            {
                passwordAdministrador = value;
            }
        }

        public int CargoAdministrador
        {
            get
            {
                return cargoAdministrador;
            }
            set
            {
                cargoAdministrador = value;
            }
        }
    }
}
