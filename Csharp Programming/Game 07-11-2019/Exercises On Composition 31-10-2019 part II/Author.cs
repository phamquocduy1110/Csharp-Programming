using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_On_Composition_31_10_2019_part_II
{
    class Author
    {
        private string Name, Email;
        private char Gender;

        public Author(string name, string email, char gender)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
        }

        public String GetName()
        {
            return this.Name;
        }

        public String GetEmail()
        {
            return this.Email;
        }

        public void SetEamil(string em)
        {
            Email = em;
        }

        public char GetGender()
        {
            return this.Gender;
        }

        public void SetEmail(string email)
        {
            this.Email = email;
        }

        public override string ToString()
        {
            return String.Format("Author[name={0}, email={1},gender={2}]", this.Name, this.Email, this.Gender);
        }
    }
}
