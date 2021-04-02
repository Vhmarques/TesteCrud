using System;
using System.Collections.Generic;
using System.Text;

namespace TesteCrud.Entities
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cpf { get; set; }

        public Client(int id, string name, int cpf)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
        }
    }
}
