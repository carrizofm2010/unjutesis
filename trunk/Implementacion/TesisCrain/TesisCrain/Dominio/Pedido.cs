using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesisCrain.Dominio
{
    public class Pedido
    {
        private int idPedido;
        private string fechaPedido;
        private double totalPedido;
        private Mesa mesa;
        public Pedido() { }
        public Pedido(int idPedido, string fechaPedido, double totalPedido, Mesa mesa) {
            this.idPedido = idPedido;
            this.fechaPedido = fechaPedido;
            this.totalPedido = totalPedido;
            this.mesa = mesa;
        }

        public virtual int IdPedido
        {
            get
            {
                return idPedido;
            }
            set
            {
                idPedido = value;
            }
        }

        public virtual string FechaPedido
        {
            get
            {
                return fechaPedido;
            }
            set
            {
                fechaPedido = value;
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

        public virtual double TotalPedido
        {
            get
            {
                return totalPedido;
            }
            set
            {
                totalPedido = value;
            }
        }
    }
}
