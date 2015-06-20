using Fresno.Endidades;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

namespace Fresno.Banco
{
    public class DataBase : DataContext
    {
        public static string DBConnection =
           "Data Source = 'isostore:FresnoBD.sdf'";

        public DataBase()
            : base(DBConnection) { }

        public Table<FeedItem> Feed
        {
            get { return this.GetTable<FeedItem>(); }
        }

        public Table<FeedTwitter> Twitter
        {
            get { return this.GetTable<FeedTwitter>(); }
        }
    }
}
