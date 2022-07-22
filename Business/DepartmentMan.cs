using DataAccess;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DepartmentMan
    {
        Repository<department> departmentRepo = new Repository<department>();

        public List<department> GetAll()
        {

            return departmentRepo.List();
        }
    }
}
