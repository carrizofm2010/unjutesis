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
    public class VideoDaoImpl:VideoDao
    {
        public void altaVideo(Video video) {
            NHibernateManager manager = new NHibernateManager();
            {

                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Save(video);
                    transaction.Commit();
                }
            }
        }
        public void modificarVideo(Video video) {
            NHibernateManager manager = new NHibernateManager();
            {

                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Update(video);
                    transaction.Commit();
                }
            }
        }
        public void bajaVideo(Video video) {
            NHibernateManager manager = new NHibernateManager();
            {

                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Delete(video);
                    transaction.Commit();
                }
            }
        }

    }
}
