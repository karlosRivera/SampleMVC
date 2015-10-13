using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class MyViewModel
    {
        public string CustomerName { get; set; }

        //[UIHint("Movies1")]
        public List<Movies> movies { get; set; }

        //[UIHint("Hobbies1")]
        public List<Hobbies> hobbies { get; set; }
    }

    public class Movies
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }

    public class Hobbies
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}