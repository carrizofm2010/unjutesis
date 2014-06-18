using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesisCrain.Dominio
{
    public class ComplementoMenu
    {

        private int idComplementoMenu;
        private Menu menu;
        private string nombreComplementoMenu;
        private string descripcionComplementoMenu;
        public ComplementoMenu() { }
        public ComplementoMenu(int idComplementoMenu, Menu menu, string nombreComplementoMenu,string descripcionComplementoMenu) {
            this.idComplementoMenu = idComplementoMenu;
            this.menu = menu;
            this.nombreComplementoMenu = nombreComplementoMenu;
            this.descripcionComplementoMenu = descripcionComplementoMenu;
        }
        public virtual int IdComplementoMenu
        {
            get
            {
                return idComplementoMenu;   
            }
            set
            {
                idComplementoMenu = value;
            }
        }

        public virtual Menu Menu
        {
            get
            {
                return menu;
            }
            set
            {
                menu = value;
            }
        }

        public virtual string NombreComplementoMenu
        {
            get
            {
                return nombreComplementoMenu;
            }
            set
            {
                nombreComplementoMenu = value;
            }
        }

        public virtual string DescripcionComplementoMenu
        {
            get
            {
                return descripcionComplementoMenu;
            }
            set
            {
                descripcionComplementoMenu = value;
            }
        }
    }
}
