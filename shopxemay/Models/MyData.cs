using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace shopxemay.Models
{
    public partial class MyData : DbContext
    {
        public MyData()
            : base("name=MyData")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
