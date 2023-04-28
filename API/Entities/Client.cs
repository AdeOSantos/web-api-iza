using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Client
    {
        [Key]
        public int clientId { get; set; }
        public string clientName { get ; set;}

        public string email { get ; set;}


        public string password { get ; set;}



    }
}