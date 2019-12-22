namespace Family_Members_Information_14_11_2019
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Breakfasts : DbContext
    {
        public Breakfasts()
            : base("name=Breakfasts")
        {
        }

        public virtual DbSet<Breakfast> Breakfasts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
