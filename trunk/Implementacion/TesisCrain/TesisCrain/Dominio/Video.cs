using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesisCrain.Dominio
{
   public class Video
    {
        private int idVideo;
        private string nombreVideo;
        private string urlVideo;

        public Video() { 
        }
        
        public Video(int idVideo, string nombreVideo, string urlVideo)
        {
            this.idVideo = idVideo;
            this.nombreVideo = nombreVideo;
            this.urlVideo = urlVideo;
        }
        public virtual int IdVideo
        {
            get
            {
                return idVideo;
            }
            set
            {
                idVideo = value;
            }
        }
        public virtual string NombreVideo
        {
            get
            {
                return nombreVideo;
            }
            set
            {
                nombreVideo = value;
            }
        }
        public virtual string UrlVideo
        {
            get
            {
                return urlVideo;
            }
            set
            {
                urlVideo = value;
            }
        }
    }
}
