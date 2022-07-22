using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class employees
    {
        [Key]
        public int employeeId { get; set; }
        [StringLength(50)]

        public string firstName { get; set; }

        public string lastName { get; set; }

        public virtual department Department { get; set; }


    }
}
