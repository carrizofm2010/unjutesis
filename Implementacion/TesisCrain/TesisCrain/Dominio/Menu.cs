using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesisCrain.Dominio
{
    public class Menu
    {
        private int idMenu;
        private string nombrePlatoMenu;
        private double precioMenu;
        private string descripcionMenu;
        private Categoria categoria;
        public Menu() { }
        public Menu(int idMenu, string nombrePlatoMenu, double precioMenu, string descripcionMenu, Categoria categoria) {
            this.idMenu = idMenu;
            this.nombrePlatoMenu = nombrePlatoMenu;
            this.precioMenu = precioMenu;
            this.descripcionMenu = descripcionMenu;
            this.categoria = categoria;
        }

        public virtual Categoria Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }

        public virtual string DescripcionMenu
        {
            get
            {
                return descripcionMenu;
            }
            set
            {
                descripcionMenu = value;
            }
        }

        public virtual int IdMenu
        {
            get
            {
                return idMenu;
            }
            set
            {
                idMenu = value;
            }
        }

        public virtual string NombrePlatoMenu
        {
            get
            {
                return nombrePlatoMenu;
            }
            set
            {
                nombrePlatoMenu = value;
            }
        }

        public virtual double PrecioMenu
        {
            get
            {
                return precioMenu;
            }
            set
            {
                precioMenu = value;

            }
        }
    }
}
