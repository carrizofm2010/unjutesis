using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesisCrain.Dominio
{
    public class Categoria
    {
        private int idCategoria;
        private string nombreCategoria;
        public Categoria() { }
        public Categoria(int idCategoria, string nombreCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
        }

        public virtual int IdCategoria
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

        public virtual string NombreCategoria
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
