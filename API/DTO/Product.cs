using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace API.Entities
{
    public class Product
    {
        
        [Key]
        public int productId { get; set; }
        public string productName { get ; set;}

        public decimal price { get ; set;}


        public string description { get ; set;}

        public byte photo { get ; set;}

    }
}