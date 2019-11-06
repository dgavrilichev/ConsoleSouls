namespace DataAccess
{
    using System.Data.Entity;

    public partial class LineageDbModel : DbContext
    {
        public LineageDbModel() : base("name=LineageDbModel")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
