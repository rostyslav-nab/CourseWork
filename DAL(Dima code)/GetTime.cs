using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GetTime : IDisposable, IUnitOfWork
    {
        private readonly TimeTable _db;

        public GetTime(TimeTable db, ContextRepository<User> userRepository,
            ContextRepository<Department> departamentRepository, ContextRepository<Group> groupRepository,
            ContextRepository<Adds> lessonRepository, ContextRepository<Rooms> auditoryRepository,
            ContextRepository<Theme> subjectRepository, ContextRepository<Manager> teatcherRepository)
        {
            _db = db;

            Users = userRepository;
            Departaments = departamentRepository;
            Groups = groupRepository;
            Lessons = lessonRepository;
            Auditories = auditoryRepository;
            Subjects = subjectRepository;
            Teachers = teatcherRepository;
        }

        public ContextRepository<User> Users { get; } //получение репозиториев 

        public ContextRepository<Department> Departaments { get; }

        public ContextRepository<Group> Groups { get; }

        public ContextRepository<Adds> Lessons { get; }

        public ContextRepository<Rooms> Auditories { get; }

        public ContextRepository<Theme> Subjects { get; }

        public ContextRepository<Manager> Teachers { get; }


        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed;


        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                _db.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
