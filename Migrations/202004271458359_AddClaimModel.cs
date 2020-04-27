namespace CashBack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClaimModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClaimModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                        companyName = c.String(),
                        orderDate = c.DateTime(nullable: false),
                        installtionDateType = c.DateTime(nullable: false),
                        paymentDate = c.DateTime(nullable: false),
                        inputeDate = c.DateTime(),
                        partnerRefNo = c.Int(nullable: false),
                        typeOfClaim = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        address1 = c.String(),
                        address2 = c.String(),
                        city = c.String(),
                        country = c.String(),
                        phoneNumber = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClaimModels");
        }
    }
}
