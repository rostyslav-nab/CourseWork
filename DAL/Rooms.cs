using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Rooms
    {
        public Rooms() { }    
        public Rooms(string Name)
        {
            this.Name = Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
