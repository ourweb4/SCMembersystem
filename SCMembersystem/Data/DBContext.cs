using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCMembersystem.Models;

namespace SCMembersystem.Data
{
    class DBContext: DbContext 
    {
        public DbSet<Member> Members { get; set; }

        public DbSet<Mtype> Mtypes { get; set; }

        public DbSet<Committe> Committes { get; set; }

        public DbSet<Invoice> Invoices
        {
            get; set; 
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

 //           modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges(); //  sycn 


            var statemanger = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager;


            var updatedentites = statemanger
            .GetObjectStateEntries(EntityState.Modified)
            .Select(e => e.Entity)
            .OfType<BaseModel>()
            .ToArray();

            foreach (var createdrec in updatedentites)
            {
                createdrec.UpdatedOn = DateTime.Now;

            }




            return base.SaveChanges();
        }
    }
}
