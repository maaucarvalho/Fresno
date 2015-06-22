using Fresno.Banco;
using Fresno.Endidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Fresno.Repositorio
{
    public class FeedsRepositorio
    {
        private static DataBase GetDataBase()
        {
            DataBase db = new DataBase();
            if (!db.DatabaseExists())
                db.CreateDatabase();

            return db;
        }

        public static List<FeedItem> Get()
        {
            DataBase db = GetDataBase();
            var query = from feed in db.Feed orderby feed.Title select feed;

            List<FeedItem> lista = new List<FeedItem>(query.AsEnumerable());
            return lista;
        }

        public static void Create(FeedItem pFeed)
        {
            DataBase db = GetDataBase();
            db.Feed.InsertOnSubmit(pFeed);
            db.SubmitChanges();

        }

        public static void Delete(FeedItem pFeeds)
        {
            DataBase db = GetDataBase();
            var query = from c in db.Feed
                        where c.Id == pFeeds.Id
                        select c;

            db.Feed.DeleteOnSubmit(query.ToList()[0]);
            db.SubmitChanges();
        }
    }
}
