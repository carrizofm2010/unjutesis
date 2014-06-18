using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesisCrain.Dominio
{
    public class TeaMenuPedido
    {
        private int idTeaMenu;
        private Pedido pedido;
        private Mesa mesa;
        private int cantidadTeaMenu;
        private string estadoTeaMenu;
        public TeaMenuPedido() { }
        public TeaMenuPedido(int idTeaMenu, Pedido pedido, Mesa mesa, int cantidadTeaMenu, string estadoTeaMenu) {
            this.idTeaMenu = idTeaMenu;
            this.pedido = pedido;
            this.mesa = mesa;
            this.cantidadTeaMenu = cantidadTeaMenu;
            this.estadoTeaMenu = estadoTeaMenu;
        }
        public virtual int IdTeaMenu
        {
            get
            {
                return idTeaMenu;
            }
            set
            {
                idTeaMenu = value;
            }         
        }

        public virtual Mesa Mesa
        {
            get
            {
                return mesa;
            }
            set
            {
                mesa = value;
            }
        }

        public virtual Pedido Pedido
        {
            get
            {
                return pedido;
            }
            set
            {
                pedido = value;
            }
        }

        public virtual string EstadoTeaMenu
        {
            get
            {
                return estadoTeaMenu;
            }
            set
            {
                estadoTeaMenu = value;
            }
        }

        public virtual int CantidadTeaMenu
        {
            get
            {
                return cantidadTeaMenu;
            }
            set
            {
                cantidadTeaMenu = value;
            }
        }
    }
}
