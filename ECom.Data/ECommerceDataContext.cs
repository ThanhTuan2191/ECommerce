namespace ECom.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ECommerceDataContext : DbContext
    {
        public ECommerceDataContext()
            : base("name=ECommerceDataContext")
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
