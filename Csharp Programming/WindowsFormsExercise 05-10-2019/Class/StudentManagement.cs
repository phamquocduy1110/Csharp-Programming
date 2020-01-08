using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExercise_05_10_2019
{
    class StudentManagement
    {
        public Member[] GetClass()
        {
            var db = new StudentDatabaseSystemManagement_21_12_2019Entities();
            var classes = db.Members.ToArray();
            return classes;
        }

        public void AddClass(int code, string fullname, bool gender, DateTime birthdate, int phonenumber, string @class, string email, string livingaddress)
        {
            var newClass = new Member();
            newClass.Code = code;
            newClass.Fullname = fullname;
            newClass.Gender = gender;
            newClass.Birthday = birthdate;
            newClass.PhoneNumber = phonenumber;
            newClass.Class = @class;
            newClass.Email = email;
            newClass.LivingAddress = livingaddress;

            var db = new StudentDatabaseSystemManagement_21_12_2019Entities();
            db.Members.Add(newClass);
            db.SaveChanges();
        }

        public void EditClass(int id, int code, string fullname, bool gender, DateTime birthdate, int phonenumber, string @class, string email, string livingaddress)
        {
            var db = new StudentDatabaseSystemManagement_21_12_2019Entities();
            var oldClass = db.Members.Find(id);

            oldClass.Code = code;
            oldClass.Fullname = fullname;
            oldClass.Gender = gender;
            oldClass.Birthday = birthdate;
            oldClass.PhoneNumber = phonenumber;
            oldClass.Class = @class;
            oldClass.Email = email;
            oldClass.LivingAddress = livingaddress;

            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteClass(int id)
        {
            var db = new StudentDatabaseSystemManagement_21_12_2019Entities();
            var @class = db.Members.Find(id);
            db.Members.Remove(@class);
            db.SaveChanges();
        }

        public Member GetClass(int id)
        {
            var db = new StudentDatabaseSystemManagement_21_12_2019Entities();
            var @class = db.Members.Find(id);
            return @class;
        }
    }
}
