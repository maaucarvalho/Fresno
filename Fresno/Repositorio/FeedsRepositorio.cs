using Fresno.Banco;
using Fresno.Endidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static List<FeedTwitter> Gets()
        {
            DataBase db = GetDataBase();
            var query = from feedtwitter in db.Twitter orderby feedtwitter.Title select feedtwitter;

            List<FeedTwitter> listatwitter = new List<FeedTwitter>(query.AsEnumerable());
            return listatwitter;
        }
    }
}
