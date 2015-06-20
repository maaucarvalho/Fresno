using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace Fresno.Endidades
{
    [Table(Name = "Feed")]

    public class FeedItem
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(CanBeNull = false)]
        public string Title { get; set; }

        [Column(CanBeNull = false)]
        public string Description { get; set; }

        [Column(CanBeNull = false)]
        public string PubDate { get; set; }

        [Column(CanBeNull = false)]
        public string Guid { get; set; }

        [Column(CanBeNull = false)]
        public string Link { get; set; }
    }
}
