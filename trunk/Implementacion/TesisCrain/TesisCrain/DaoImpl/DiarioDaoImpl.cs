using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesisCrain.Dominio;
using TesisCrain.Dao;
using TesisCrain.Config;
using NHibernate;

namespace TesisCrain.DaoImpl
{
    public class DiarioDaoImpl: DiarioDao
    {
        public void altaDiario(Diario diario) {
            NHibernateManager manager = new NHibernateManager();
            {

                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Save(diario);
                    transaction.Commit();
                }
            }
        }
        public void modificarDiario(Diario diario) {
            NHibernateManager manager = new NHibernateManager();
            {

                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Update(diario);
                    transaction.Commit();
                }
            }
        }
        public void bajaDiario(Diario diario) {
            NHibernateManager manager = new NHibernateManager();
            {

                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Delete(diario);
                    transaction.Commit();
                }
            }
        }
    }
}
