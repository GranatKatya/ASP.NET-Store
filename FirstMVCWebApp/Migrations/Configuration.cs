namespace FirstMVCWebApp.Migrations
{
    using FirstMVCWebApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstMVCWebApp.Models.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FirstMVCWebApp.Models.StoreContext";
        }

        protected override void Seed(FirstMVCWebApp.Models.StoreContext context)
        {

            //context.Categories.Add(new Category
            //{
            //    Id = 1,
            //    Name = "For body",
              
            //});
            //context.Categories.Add(new Category
            //{
            //    Id = 2,
            //    Name = "For hair",

            //});
            //context.Categories.Add(new Category
            //{
            //    Id = 3,
            //    Name = "For face",

            //});

          //  context.SaveChanges();

       //     base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
