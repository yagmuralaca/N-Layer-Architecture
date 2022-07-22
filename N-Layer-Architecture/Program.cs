
using Business;

namespace N_Layer_Architecture
{
    class Program
    {

        static void Main(string[] args)
        {
            EmployeeMan em = new EmployeeMan();

      
            foreach (var item in em.GetAll())
            {
                Console.WriteLine("Employee Id:" + item.employeeId + " " + "Name:" + " " + item.firstName + " " + item.lastName );
            }

        }

    }
}