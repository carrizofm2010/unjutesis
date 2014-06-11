using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    class Categoria
    {
        private int idCategoria;
        private int nombreCategoria;

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }
            set
            {
                idCategoria = value;
            }
        }

        public int NombreCategoria
        {
            get
            {
                return nombreCategoria;
            }
            set
            {
                nombreCategoria = value;
            }
        }
    }
}
