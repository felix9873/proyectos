using ProyectoModulo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees = new List<Employee>();
        private int next_id = 1;
        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void Add(Employee entity)
        {
           entity.Id = next_id++;
            _employees.Add(entity);
        }

        public void Update(Employee entity)
        {
            var index = _employees.FindIndex(e => e.Id == entity.Id);

            if (index != -1) _employees[index] = entity;
        }

        public void Delete(Employee entity)
        {
            _employees.Remove(entity);
        }

        public List<Employee> GetEmployeByName(string employeName)
        {
            return _employees.Where(e => e.Name == employeName).ToList();
        }

        
    }
}
