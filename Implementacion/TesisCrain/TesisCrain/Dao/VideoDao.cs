using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesisCrain.Dominio;

namespace TesisCrain.Dao
{
    public interface VideoDao
    {
        void altaVideo(Video video);
        void modificarVideo(Video video);
        void bajaVideo(Video video);

    }
}
