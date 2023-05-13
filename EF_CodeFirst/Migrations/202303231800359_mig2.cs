namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uruns", "UrunFiyati", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Uruns", "UrunFiyati");
        }
    }
}
