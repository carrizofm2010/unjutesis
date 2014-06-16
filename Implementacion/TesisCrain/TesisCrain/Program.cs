using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesisCrain.Dominio;
using TesisCrain.DaoImpl;

namespace TesisCrain
{
    class Program
    {
        static void Main(string[] args)
        {
          //  PruebaConexion prueba = new PruebaConexion();
            Categoria categoria = new Categoria(3, "Minutas");
            CategoriaDaoImpl daoImpl = new CategoriaDaoImpl();
            daoImpl.saveCategoria(categoria);
        }
    }
}
