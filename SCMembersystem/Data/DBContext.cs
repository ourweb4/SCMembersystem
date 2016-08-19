// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-08-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-18-2016
// ***********************************************************************
// <copyright file="DBContext.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
/// @file Data\DBContext.cs
///
/// Implements the database context class.

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

    /// <summary>
    /// Class DBContext.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    class DBContext : DbContext 
    {

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
        public DbSet<Member> Members { get; set; }

        /// <summary>
        /// Gets or sets the mtypes.
        /// </summary>
        /// <value>The mtypes.</value>
        public DbSet<Mtype> Mtypes { get; set; }

        /// <summary>
        /// Gets or sets the committes.
        /// </summary>
        /// <value>The committes.</value>
        public DbSet<Committe> Committes { get; set; }

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        /// <value>The invoices.</value>
        public DbSet<Invoice> Invoices
        {
            get; set; 
            
        }

        /// <summary>
        /// Gets or sets the clubs.
        /// </summary>
        /// <value>The clubs.</value>
        public DbSet<Club> Clubs { get; set; }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.</remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

 //           modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>The number of state entries written to the underlying database. This can include
        /// state entries for entities and/or relationships. Relationship state entries are created for
        /// many-to-many relationships and relationships where there is no foreign key property
        /// included in the entity class (often referred to as independent associations).</returns>
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
