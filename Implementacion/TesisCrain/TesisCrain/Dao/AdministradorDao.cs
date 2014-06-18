using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesisCrain.Dominio;

namespace TesisCrain.Dao
{
    public interface AdministradorDao
    {
        bool verificarAdministrador(Administrador administrador);
    }
}
