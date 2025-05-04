using ProyectoModulo2.Models;
using ProyectoModulo2.Repository;

namespace ProyectoModulo2.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }
        public List<Employee> GetEmployeByName(string employeName)
        {
            return  _employeeRepository.GetEmployeByName(employeName);
        }

        
    }
}
