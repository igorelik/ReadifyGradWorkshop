using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SimpleModel
    {
        public string Name { get; set; }
        public string Nickname { get; set; }


        public void Initialise()
        {
            Name = "Initial Name";
            Nickname = "Initial Nickname";
        }
    }
}