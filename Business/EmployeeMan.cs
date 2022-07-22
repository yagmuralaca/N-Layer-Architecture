using DataAccess;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EmployeeMan
    {
        Repository<employees> employeeRepo = new Repository<employees>();

        public List<employees> GetAll()
        {

            return employeeRepo.List();
        }
    }
}
