using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesisCrain.DaoImpl;
using TesisCrain.Dominio;

namespace TesisCrain.Servicios
{
    class Facade
    {
        VideoDaoImpl videoDaoImpl = new VideoDaoImpl();
        DiarioDaoImpl diarioDaoImpl = new DiarioDaoImpl();
        CategoriaDaoImpl categoriaDaoImpl = new CategoriaDaoImpl();
        AdministradorDaoImpl ddministradorDaoImpl = new AdministradorDaoImpl();
        
        //Servicios de video
        public void altaVideo(Video video) {
            videoDaoImpl.altaVideo(video);
        }
        public void modificarVideo(Video video)
        {
            videoDaoImpl.modificarVideo(video);
        }
        public void bajaVideo(Video video)
        {
            videoDaoImpl.bajaVideo(video);
        }
        //Servicios de diario
        //Servicios de categoria
        //Servicios de administrador
        
    }
}
