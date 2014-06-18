using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesisCrain.Dominio;

namespace TesisCrain.Dao
{
    public interface DiarioDao
    {
        void altaDiario(Diario diario);
        void modificarDiario(Diario diario);
        void bajaDiario(Diario diario);

        
    }
}
