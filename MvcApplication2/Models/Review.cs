using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string gameID { get; set; }
    }
}