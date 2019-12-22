using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_All_Members_25_11_2019
{
    public class MemberView
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string gender { get; set; }
        public string birthday { get; set; }
        public string status { get; set; }
        public string hometown { get; set; }
        public string living { get; set; }
        public string occupation { get; set; }
        public string Father_id { get; set; }
        public string Mother_id { get; set; }
        public string spouse_id { get; set; }

        public MemberView(member member)
        {
            this.id = member.id;
            this.fullname = member.fullname;
            this.gender = member.gender == true ? "Male" : "Female";
            if (member.birthday != null)
                this.birthday = string.Format("{0}/{1}/{2}",
                    member.birthday.Value.Day,
                    member.birthday.Value.Month,
                    member.birthday.Value.Year
                    );
            if (member.status.HasValue)
            {
                this.status = member.status.Value == true ? "Living" : "Deceased";
            }
            var db = new FamilyMembersManagementEntities();
            if (member.Father_id.HasValue)
            {
                var father = db.members.Find(member.Father_id.Value);
                this.Father_id = father.fullname;
            }

            if (member.Mother_id.HasValue)
            {
                var mother = db.members.Find(member.Mother_id.Value);
                this.Mother_id = mother.fullname;
            }

            if (member.spouse_id.HasValue)
            {
                var spouse = db.members.Find(member.spouse_id.Value);
                this.spouse_id = spouse.fullname;
            }
            this.hometown = member.hometown;
            this.living = member.living;
            this.occupation = member.occupation;

        }
    }
}
