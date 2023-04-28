using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Address
    {
        
    
        [Key]
        public int id { get; set; }
        public int clientId { get; set; }
        public string location { get ; set;}

        public int number { get ; set;}

        public string city { get ; set;}


        public string state { get ; set;}

        public int cep { get ; set;}
        


    }
}