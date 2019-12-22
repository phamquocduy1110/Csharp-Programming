namespace Dishes_Database_Management_12_10_2019
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantEnitities : DbContext
    {
        public RestaurantEnitities()
            : base("name=RestaurantEnitities1")
        {
        }

        public virtual DbSet<Breakfast> Breakfasts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
