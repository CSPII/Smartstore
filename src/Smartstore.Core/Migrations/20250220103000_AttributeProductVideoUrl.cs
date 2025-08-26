using FluentMigrator;
using Smartstore.Core.Catalog.Products;

namespace Smartstore.Core.Data.Migrations
{
    [MigrationVersion("2025-08-21 17:30:00", "Core: Attribute product video url")]
    internal class AttributeProductVideoUrl : Migration
    {
        const string ProductTable = nameof(Product);
        const string ProductVideoUrlColumn = nameof(Product.ProductVideoUrl);

        public override void Up()
        {
            if (!Schema.Table(ProductTable).Column(ProductVideoUrlColumn).Exists())
            {
                Create.Column(ProductVideoUrlColumn).OnTable(ProductTable)
                    .AsString(100)
                    .Nullable();
            }
        }

        public override void Down()
        {
            if (Schema.Table(ProductTable).Column(ProductVideoUrlColumn).Exists())
            {
                Delete.Column(ProductVideoUrlColumn).FromTable(ProductTable);
            }
        }
    }
}
