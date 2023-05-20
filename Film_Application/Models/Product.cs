using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Film_Application.Models
{
    public class Movie  
    {
       [Key] public int Id { get;set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get;set; }
        public int Count { get; set; }
        public string NameComapany { get; set; }    
        public DateTime FileCraetedData { get;set; }
    }
}
