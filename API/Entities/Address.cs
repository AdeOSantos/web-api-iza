using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Address
    {
        
    

        public int id { get; set; }
        public string location { get ; set;}

        public int number { get ; set;}

        public string city { get ; set;}


        public string state { get ; set;}

        public int cep { get ; set;}
        


    }
}