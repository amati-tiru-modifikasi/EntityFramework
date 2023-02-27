using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiFramework.Models
{
    public class Products
    {
        public int Id {get; set;}

        //[Required] // default dari .NET adalah nullable
        public string Name {get; set;} = null;

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price {get; set;}
    }
}