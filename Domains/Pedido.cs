using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.EfCore.Tarde.Domains
{
    public class Pedido : BaseDomain
    {
        BaseDomain base1 = new BaseDomain();
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
       
    }
}
