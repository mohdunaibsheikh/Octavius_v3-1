using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Incedo_Octavius_Demo_2.Data
{
    public class Incedo_Octavius_Demo_2_BU_Spec_Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Incedo_Octavius_Demo_2_BU_Spec_Context() : base("name=Incedo_Octavius_Demo_2_BU_Spec_Context")
        {
            try
            {
                //var objectContext = (this as IObjectContextAdapter).ObjectContext;
                //objectContext.CommandTimeout = 300;
            }
            catch (Exception Ex)
            {

                throw;
            }
        }

        ///public System.Data.Entity.DbSet<Incedo_Octavius_Demo_2.Models.BusinessUserSpecialtyModel> BusinessUserSpecialtyModels { get; set; }

        public virtual DbSet<Incedo_Octavius_Demo_2.Models.BusinessUserSpecialtyModel> BusinessUserSpecialtyModels { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            //throw new UnintentionalCodeFirstException();
        }

    }
}
