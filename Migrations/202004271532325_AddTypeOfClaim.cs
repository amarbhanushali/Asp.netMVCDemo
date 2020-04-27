namespace CashBack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTypeOfClaim : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TypeOfClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        claimType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypesOfForms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ClaimModels", "TypesOfFormId", c => c.Int(nullable: false));
            AddColumn("dbo.ClaimModels", "typeOfClaimId", c => c.Int(nullable: false));
           
            CreateIndex("dbo.ClaimModels", "TypeOfClaimId");
            CreateIndex("dbo.ClaimModels", "TypesOfFormId");
            AddForeignKey("dbo.ClaimModels", "TypeOfClaimId", "dbo.TypeOfClaims", "Id");
            AddForeignKey("dbo.ClaimModels", "TypesOfFormId", "dbo.TypesOfForms", "Id");
            DropColumn("dbo.ClaimModels", "type");
            DropColumn("dbo.ClaimModels", "typeOfClaim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClaimModels", "typeOfClaim", c => c.String());
            AddColumn("dbo.ClaimModels", "type", c => c.String());
            DropForeignKey("dbo.ClaimModels", "TypesOfFormId", "dbo.TypesOfForms");
            DropForeignKey("dbo.ClaimModels", "TypeOfClaimId", "dbo.TypeOfClaims");
            DropIndex("dbo.ClaimModels", new[] { "TypesOfFormId" });
            DropIndex("dbo.ClaimModels", new[] { "TypeOfClaimId" });
            DropColumn("dbo.ClaimModels", "TypesOfFormId");
            DropColumn("dbo.ClaimModels", "TypeOfClaimId");
            DropColumn("dbo.ClaimModels", "typeOfClaimId");
            DropColumn("dbo.ClaimModels", "TypesOfFormId");
            DropTable("dbo.TypesOfForms");
            DropTable("dbo.TypeOfClaims");
        }
    }
}
