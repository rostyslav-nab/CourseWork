using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL
{
    public class TimeOperations
    {
        IMapper SubjectToM = new MapperConfiguration(cfg => cfg.CreateMap<Adds, MLesson>()).CreateMapper();
        private readonly GetTime _uow;

        public TimeOperations(GetTime uow)
        {
            this._uow = uow;
        }

        public TimeOperations()
        {
            TimeTable context = new TimeTable();
            _uow = new GetTime(context, new ContextRepository<User>(context), new ContextRepository<Department>(context), new ContextRepository<Group>(context), new ContextRepository<Adds>(context), new ContextRepository<Rooms>(context), new ContextRepository<Theme>(context), new ContextRepository<Manager>(context));
        }

        public List<MLesson> GetLessons()
        {
            return SubjectToM.Map<IEnumerable<Adds>, List<MLesson>>(_uow.Lessons.Get());

        }

        public MLesson GetLessonByID(int id)
        {
            return SubjectToM.Map<Adds, MLesson>(_uow.Lessons.GetOne(x => (x.Id == id)));

        }

        public void AddLesson(MLesson subject)
        {
            _uow.Lessons.Create(new Adds { Day = subject.Day, Para = subject.Para, Auditory = subject.Auditory, Group = subject.Group, Subject = subject.Subject, Teacher = subject.Teacher});
            _uow.Save();
        }

        public void DeleteLessonByID(int id)
        {
            _uow.Lessons.Remove(_uow.Lessons.FindById(id));
            _uow.Save();
        }
        
    }
}
