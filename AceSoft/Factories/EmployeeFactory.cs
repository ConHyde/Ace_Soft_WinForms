using AceSoftAccess;
using AceSoftServices.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceSoft
{
    public sealed class EmployeeFactory 
    {

        private static EmployeeFactory instance = null;
        private static readonly object padlock = new EmployeeFactory();

        public EmployeeFactory()
        {
        }

        public static EmployeeFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeFactory();
                    }
                    return instance;
                }
            }
        }
        //public List<String> GetActiveEmployees()
        //{

        //}

        public List<Employee> GetEmployees()
        {
            EmployeeController controller = new EmployeeController();

            return controller.Get().ToList();
        }
        public Employee GetEmployeeFromId(int id)
        {
            EmployeeController controller = new EmployeeController();

            return controller.GetEmployeeFromId(id);
        }
    }
}
