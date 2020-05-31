using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Manager
    {
        public Manager()
        {
        }

        public Manager(Department departament, string name, ICollection<Adds> lessons)
        {
            Departament = departament;
            Name = name;
            Lessons = lessons;
        }

        public int Id { get; set; }
        public Department Departament { get; set; }
        public string Name { get; set; }
        public ICollection<Adds> Lessons { get; set; }
    }
}
