﻿
using ProyectoModulo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Services
{
    public interface IEmployeeService
    {
        
        List<Employee> GetEmployeByName(string employeName);
    }
}
