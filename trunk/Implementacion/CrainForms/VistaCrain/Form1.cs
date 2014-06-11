using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VistaCrain
{
    public partial class Form1 : Form
    {
       MySqlConnection conexion=new MySqlConnection();
   
        public Form1()
        {
            InitializeComponent();
            this.iniciarConexion();
        }
        private void iniciarConexion() {
            try {
                string servidor = "localhost";
                string baseDatos = "dbms_crain";
                string usuario = "root";
                string password = "crain";
                string cadenaConexion = "SERVER=" + servidor + ";" + "DATABASE=" + baseDatos + ";" + "UID=" + usuario + ";" + "PASSWORD=" + password + ";";  
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("La conexion se  ha realizado con exito","Bien hecho!");
            }catch(MySqlException){
                MessageBox.Show("Ocurrio un error al intentar conectarse", "ERROR");
            }
        }
    }
}
