using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkshopMVC.Models
{
    public class SimpleModel
    {
        public SimpleModel()
        {

        }

        public void Initialise()
        {
            Name = "A";
            Nickname = "B";
        }

        public string FullName => $"{Name} - {Nickname}";
        
        public string Name { get; set; }
        public string Nickname { get; set; }
    }
}