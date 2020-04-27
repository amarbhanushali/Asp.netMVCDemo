namespace CashBack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClaimType : DbMigration
    {
        public override void Up()
        {
            Sql("insert into TypeOfClaims (claimType) Values ('Ducted')");
            Sql("insert into TypeOfClaims (claimType) Values ('Package')");
            Sql("insert into TypesOfForms (type) Values ('Side Discharge')");
            Sql("insert into TypesOfForms (type) Values ('Top Discharge')");
            Sql("insert into TypesOfForms (type) Values ('Package')");

        }
        
        public override void Down()
        {
        }
    }
}
