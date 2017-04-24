namespace PqDiversoes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filtromulti : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parques", "Username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parques", "Username");
        }
    }
}
