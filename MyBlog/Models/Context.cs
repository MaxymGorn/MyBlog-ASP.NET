namespace MyBlog.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        public Context()
            : base("name=Portfolio")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Statics> Statics { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Contact_Details> Contact_Details { get; set; }
        public DbSet<ProjectSClientsS> ProjectSClientsSes { get; set; }
        public DbSet<WHAT_CAN__I_DO> wHAT_CAN__I_DOs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}