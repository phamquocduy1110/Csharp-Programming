using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Members_Information_15_11_2019
{
    class Family_Members_Management
    {
        public  member[] GetClasses()
        {
            var db = new FamilyMembersManagementEntities();
            var classes = db.members.ToArray();
            return classes;
        }

        public void AddClass(string fullname, string hometown, string currentliving, string occupation)
        {
            var newClass = new member();
            newClass.fullname = fullname;
            newClass.hometown = hometown;
            newClass.living = currentliving;
            newClass.occupation = occupation;

            var db = new FamilyMembersManagementEntities();
            db.members.Add(newClass);
            db.SaveChanges();
        }

        public void EditClass(int id, string fullname, string hometown, string currentliving, string occupation)
        {
            var db = new FamilyMembersManagementEntities();
            var oldClass = db.members.Find(id);

            oldClass.fullname = fullname;
            oldClass.hometown = hometown;
            oldClass.living = currentliving;
            oldClass.occupation = occupation;

            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteClass(int id)
        {
            var db = new FamilyMembersManagementEntities();
            var @class = db.members.Find(id);
            db.members.Remove(@class);
            db.SaveChanges();
        }

        public member GetClass(int id)
        {
            var db = new FamilyMembersManagementEntities();
            var @class = db.members.Find(id);
            return @class;
        }
    }
}
