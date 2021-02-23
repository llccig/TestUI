using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace TestUI.EntityFrameworkCore
{
    public static class TestUIDbContextModelCreatingExtensions
    {
        public static void ConfigureTestUI(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TestUIConsts.DbTablePrefix + "YourEntities", TestUIConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}