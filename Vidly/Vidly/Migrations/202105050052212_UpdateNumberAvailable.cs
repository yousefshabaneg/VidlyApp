namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNumberAvailable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies Set NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
