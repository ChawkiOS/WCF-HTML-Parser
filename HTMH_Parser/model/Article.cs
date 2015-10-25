using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMH_Parser.model
{
    public class Article
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public Uri URL { get; set; }
        public string Image { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}