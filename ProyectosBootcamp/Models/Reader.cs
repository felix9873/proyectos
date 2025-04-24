using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosBootcamp.Models
{
    public class Reader
    {

        private string _name;
        private int _age;
        private int _id;

        public int Id { get => _id;}
        public int Age { get => _age; set => _age = value; }

        public string Name { get => _name; set => _name = value; }

        public Reader(int age, string name)
        {
            _id++;
            _age = age;
            _name = name;
        }


    }
}
