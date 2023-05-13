﻿namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uruns", "StokMiktari", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Uruns", "StokMiktari");
        }
    }
}
