namespace Koo.Web.Migrations
{
    using Koo.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Koo.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Koo.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(Koo.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Projects.AddOrUpdate(
                p => p.Title,
                new Project { Title = "上海浦江", ShortDescription = "浦江浦江浦江浦江浦江浦江浦江 ", Description = "浦江浦江浦江浦江浦江浦江浦江浦江浦江浦江", IsHighlighted = true, RatingValue = 5, CoverImageUrl = "4.jpg" },

                new Project { Title = "上海新江湾君庭", ShortDescription = "新江湾君庭 新江湾君庭 新江湾君庭 新江湾君庭", Description = "新江湾 新江湾新江湾新江湾新江湾新江湾新江湾新江湾新江湾", IsHighlighted = true, RatingValue = 3, CoverImageUrl = "2.jpg" },

                new Project { Title = "上海新江湾君庭2", ShortDescription = "新江湾君庭 新江湾君庭 新江湾君庭 新江湾君庭", Description = "新江湾 新江湾新江湾新江湾新江湾新江湾新江湾新江湾新江湾", IsHighlighted = false, RatingValue = 5, CoverImageUrl = "3.jpg" }

                );

            /*context.SupportAmounts.AddOrUpdate(
                 a => a.Id,
                 new SupportAmount { ProjectId = 1, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 1, Amount = 2200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 1, Amount = 12000, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 1, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 2, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 2, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 2, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 3, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 3, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 3, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 3, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 3, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 3, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount { ProjectId = 3, Amount = 1200, ReturnContent = "180天 - 年化7.8%" },
                 new SupportAmount {  ProjectId = 1, Amount = 1200, ReturnContent="180天 - 年化7.8%"}
                 );*/
        }
    }
}
