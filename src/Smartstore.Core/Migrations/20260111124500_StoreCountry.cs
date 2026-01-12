using FluentMigrator;
using Smartstore.Core.Stores;

namespace Smartstore.Core.Data.Migrations
{
    [MigrationVersion("2026-01-11 12:45:00", "Core: StoreCountry")]
    internal class StoreCountry : Migration
    {
        public override void Up()
        {
            var tableName = nameof(Store);
            var storeCountry = nameof(Store.DefaultCountry);

            if (!Schema.Table(tableName).Column(storeCountry).Exists())
            {
                Create.Column(storeCountry).OnTable(tableName).AsString().NotNullable().WithDefaultValue("CZ");
            }
        }

        public override void Down()
        {
        }
    }
}
