using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesisCrain.Dominio
{
    public class Administrador
    {
        private int idAdministrador;
        private string nombreAdministrador;
        private string apellidoAdministrador;
        private string usuarioAdministrador;
        private string passwordAdministrador;
        private string cargoAdministrador;
        public Administrador(){}
        public Administrador(int idAdministrador, string nombreAdministrador, string apellidoAdministrador, string usuarioAdministrador, string passwordAdministrador, string cargoAdministrador)
        {
            this.idAdministrador = idAdministrador;
            this.nombreAdministrador = nombreAdministrador;
            this.apellidoAdministrador = apellidoAdministrador;
            this.usuarioAdministrador = usuarioAdministrador;
            this.passwordAdministrador = passwordAdministrador;
            this.cargoAdministrador = cargoAdministrador;
            
        }
        public virtual int IdAdministrador
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

        public virtual string NombreAdministrador
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

        public virtual string ApellidoAdministrador
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

        public virtual string UsuarioAdministrador
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

        public virtual string PasswordAdministrador
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

        public virtual string CargoAdministrador
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
