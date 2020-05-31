using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Department
    {
        public Department()
        {
        }

        public Department(string name, ICollection<Manager> teachers, ICollection<Group> groups)
        {
            Name = name;
            Teachers = teachers;
            Groups = groups;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Manager> Teachers { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
