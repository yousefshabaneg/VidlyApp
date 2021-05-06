namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resetIdentityMovies : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('Movies', RESEED, 0)");
            
        }

        public override void Down()
        {
        }
    }
}
