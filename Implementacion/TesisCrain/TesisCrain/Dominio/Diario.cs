using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesisCrain.Dominio
{
    public class Diario
    {
        private int idDiario;
        private string nombreDiario;
        private string urlDiario;

        public Diario() { }
        public Diario(int idDiario, string nombreDiario, string urlDiario) {
            this.idDiario = idDiario;
            this.nombreDiario = nombreDiario;
            this.urlDiario = urlDiario;
        }

        public virtual int IdDiario
        {
            get
            {
                return idDiario;
            }
            set
            {
                idDiario = value;
            }
        }

        public virtual string NombreDiario
        {
            get
            {
                return nombreDiario;
            }
            set
            {
                nombreDiario = value;
            }
        }

        public virtual string UrlDiario
        {
            get
            {
                return urlDiario;
            }
            set
            {
                urlDiario = value;
            }
        }
    }
}
