using ProyectoModulo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Repository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
       List<Employee> GetEmployeByName(string employeName);
    }
}
