using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace taskcodefirst
{
    class purchase
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int Cid { get; set; }
        public int Pid { get; set; }
        public virtual customer customer {get;set;}
        public virtual product product { get; set; }

    }
}
