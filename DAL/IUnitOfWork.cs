using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork
    {
        ContextRepository<User> Users { get; }  //получение доступа к репозиториям
        ContextRepository<Department> Departaments { get; }
        ContextRepository<Group> Groups { get; }
        ContextRepository<Adds> Lessons { get; }
        ContextRepository<Rooms> Auditories { get; }
        ContextRepository<Theme> Subjects { get; }
        ContextRepository<Manager> Teachers { get; }
        void Save();
        void Dispose();
    }
}
