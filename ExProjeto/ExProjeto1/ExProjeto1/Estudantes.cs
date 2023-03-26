using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProjeto1
{
    class Estudantes
    {

        public string Name { get; set; }
        public string Email { get; set; }


        public Estudantes()
        {

        }
        public Estudantes(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void Change(string change)
        {
            Email = change;
        }
   


        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}";
        }

    }
}
