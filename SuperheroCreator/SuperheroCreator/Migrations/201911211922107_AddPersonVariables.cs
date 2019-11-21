namespace SuperheroCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonVariables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "superHeroName", c => c.String());
            AddColumn("dbo.People", "primaryAbility", c => c.String());
            AddColumn("dbo.People", "secondaryAbility", c => c.String());
            AddColumn("dbo.People", "catchPhrase", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "catchPhrase");
            DropColumn("dbo.People", "secondaryAbility");
            DropColumn("dbo.People", "primaryAbility");
            DropColumn("dbo.People", "superHeroName");
        }
    }
}
