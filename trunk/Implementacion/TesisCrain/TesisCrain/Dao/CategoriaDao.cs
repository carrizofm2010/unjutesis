using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesisCrain.Dominio;
using TesisCrain.DaoImpl;

namespace TesisCrain.Dao
{
    public interface CategoriaDao
    {
        void altaCategoria(Categoria categoria);
        void modificarCategoria(Categoria categoria);
        void bajaCategoria(Categoria categoria);

        void saveCategoria(Categoria categoria);
    }
}
