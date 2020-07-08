using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class MemberView
    {
        public int id { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Status { get; set; }
        public string Hometowm { get; set; }
        public string Currentliving { get; set; }
        public string Occupation { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public string Spouse{ get; set; } 
       
        public MemberView(Member member)
        {
            this.id = member.id;
            this.Fullname = member.Fullname;
            this.Gender = member.Gender == true ? "Nam" : "Nu";
            if (member.Birthday != null)
                this.Birthday = string.Format("{0}/{1}/{2}",
                    member.Birthday.Value.Day,
                    member.Birthday.Value.Month,
                    member.Birthday.Value.Year
                    );
            if (member.Status.HasValue)
                this.Status = member.Status.Value == true ? "Living" : "Deceased";
            var db = new OOPCSEntities();
            if(member.Father_id.HasValue)
            {
                var father = db.Members.Find(member.Father_id.Value);
                this.Father = father.Fullname;
            }

            if (member.Mother_id.HasValue)
            {
                var mother = db.Members.Find(member.Mother_id.Value);
                this.Mother = mother.Fullname;
            }

            if (member.Spouse_id.HasValue)
            {
                var spouse = db.Members.Find(member.Spouse_id.Value);
                this.Spouse = spouse.Fullname;
            }
            this.Hometowm = member.Hometowm;
            this.Currentliving = member.Currentliving;
            this.Occupation = member.Occupation;

        }
    }
}
