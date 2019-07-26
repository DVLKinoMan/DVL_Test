namespace DVL_Test.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DVL_TestModel : DbContext
    {
        public DVL_TestModel()
            : base("name=DVL_TestMod")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }


        public DbSet<Word> Words { get; set; }
    }
}
