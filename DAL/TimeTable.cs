using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text.RegularExpressions;

namespace DAL
{
    public class TimeTable : DbContext
    {
        public TimeTable() : base("DbConnection")
        {
        }  

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();  
        }

        static TimeTable()  
        {
            Database.SetInitializer(new DataModelInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Adds> Lessons { get; set; }
        public DbSet<Rooms> Auditories { get; set; }
        public DbSet<Theme> Subjects { get; set; }
        public DbSet<Manager> Teachers { get; set; }
    }
}
