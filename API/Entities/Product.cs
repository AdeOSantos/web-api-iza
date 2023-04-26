using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace API.Entities
{
    public class Product
    {
        

        public int id { get; set; }
        public string productName { get ; set;}

        public decimal price { get ; set;}


        public string description { get ; set;}

        public byte photo { get ; set;}

    }
}