using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class department
    {
        [Key]

        public int departmentId { get; set; }

        public string departmentName { get; set; }

        public ICollection<employees> employees { get; set; }

    }
}
