using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPressApp
{
    public class Link
    {
        public int id { get; set; }

        public string SiteCode { get; set; }

        public string SiteLink { get; set; }

        public string NewsType { get; set; }

        public DateTime  NewsDate { get; set; }


        public string NewsTitle { get; set; }

        public string NewsDescription { get; set; }

        public string NewsContent { get; set; }
    }
}
