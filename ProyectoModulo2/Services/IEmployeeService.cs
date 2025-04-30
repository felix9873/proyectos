
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
        void AddBook(Book book);
        void UpdateBook(int id);

        void DeleteBook(int id);

        void GetById(int id);

        void GetBook();
    }
}
