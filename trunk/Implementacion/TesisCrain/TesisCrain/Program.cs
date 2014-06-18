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
            //Video video = new Video(1,"google","www.google.com");
            //VideoDaoImpl videoDaoImpl = new VideoDaoImpl();
            //videoDaoImpl.bajaVideo(video);
            Diario diario = new Diario(1, "Tribuno", "www.eltribunodejujuy.com");
            DiarioDaoImpl diarioDaoImpl = new DiarioDaoImpl();
            diarioDaoImpl.bajaDiario(diario);

        }
    }
}
