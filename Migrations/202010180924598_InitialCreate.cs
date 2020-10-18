namespace Ateshgah_Insurance_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientUniqueId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        TelephoneNr = c.String(),
                        Client_Email = c.String(),
                        Clien_Password = c.String(),
                        Confirm_Pass = c.String(),
                    })
                .PrimaryKey(t => t.ClientUniqueId);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        LoanId = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                        InteresRate = c.Double(nullable: false),
                        LoanPeriod = c.Int(nullable: false),
                        PayoutDate = c.DateTime(nullable: false),
                        ClientID = c.Int(nullable: false),
                        Client_ClientUniqueId = c.Int(),
                    })
                .PrimaryKey(t => t.LoanId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientUniqueId)
                .Index(t => t.Client_ClientUniqueId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoicesID = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                        DueData = c.DateTime(nullable: false),
                        InvoiceNr = c.Int(nullable: false),
                        OrderNr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoicesID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Loans", "Client_ClientUniqueId", "dbo.Clients");
            DropIndex("dbo.Loans", new[] { "Client_ClientUniqueId" });
            DropTable("dbo.Invoices");
            DropTable("dbo.Loans");
            DropTable("dbo.Clients");
        }
    }
}
