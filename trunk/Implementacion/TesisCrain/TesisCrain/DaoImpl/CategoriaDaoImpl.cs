using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using TesisCrain.Dominio;
using TesisCrain.Dao;
using TesisCrain.Config;


namespace TesisCrain.DaoImpl
{
    public class CategoriaDaoImpl: CategoriaDao
    {
        public void saveCategoria(Categoria categoria) {
            
         
            //ISessionFactory factory =
            //new NHibernate.Cfg.Configuration().Configure("hibernate.cfg.xml").BuildSessionFactory();
            //using (ISession session = factory.OpenSession())
            //{
            //    Console.WriteLine("NOMBRE DE LA CATEGORIA: "+categoria.NombreCategoria);
            //    session.Save(categoria);
            //    session.Close();
            //}
            //factory.Close(); 
            NHibernateManager manager = new NHibernateManager();
            {

                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Save(categoria);
                    transaction.Commit();
                }
            }
        }
    }
}
