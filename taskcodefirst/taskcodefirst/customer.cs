using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace taskcodefirst
{
    class customer
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
        public  List<product> Product { get; set; }
    public    List<product> plis = new List<product>();

    }
}
