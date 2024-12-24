using AIC_LAB5.DAL;
using AIC_LAB5.DAL.Repository;
using AIC_LAB5.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class EntityFramework_StudentRepository : IEntityRepository<Student>
    {

        public void Create(Student entity)
        {

            using (ApplicationContext db = new ApplicationContext())
            {

                db.Students.Add(entity);

                db.SaveChanges();
            }
        }

        public void Delete(Student entity)
        {

            using (ApplicationContext db = new ApplicationContext())
            {

                db.Students.Remove(entity);

                db.SaveChanges();
            }
        }

        public IEnumerable<Student> ReciveAll()
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                return db.Students.ToList<Student>();
            }
        }

        public void Update(Student toUpdate, Student newData)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                var student = db.Students.Find(toUpdate.Id);
                if (student != null)
                {
                    student.Name = newData.Name;
                    student.Speciality = newData.Speciality;
                    student.Group = newData.Group;
                    db.SaveChanges();
                }
            }
        }
    }
}
