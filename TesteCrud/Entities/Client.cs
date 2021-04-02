using System;
using System.Collections.Generic;
using System.Text;

namespace TesteCrud.Entities
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        public Client(int id, string name, string cpf)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
        }

        public override string ToString()
        {
            return "Id: " + Id
                   + "\nNome: " + Name
                   + "\nCPF: " + Cpf;
        }
    }
}
