namespace SuperheroCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingHeroImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "heroImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "heroImage");
        }
    }
}
