using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesisCrain.Dominio
{
   public class Mesa
    {
       private int idMesa;
       private string descripcionMesa;
       public Mesa() { }
       public Mesa(int idMesa,string descripcionMesa) {
           this.idMesa = idMesa;
           this.descripcionMesa = descripcionMesa;
       }
        public virtual string DescripcionMesa
        {
            get
            {
                return descripcionMesa;
            }
            set
            {
                descripcionMesa = value;
            }
        }

        public virtual int IdMesa
        {
            get
            {
                return idMesa;
            }
            set
            {
                idMesa = value;
            }
        }
    }
}
