namespace FamilyBudgetSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        Ballance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.AccountID);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ExpenseID = c.Int(nullable: false, identity: true),
                        ExpenseName = c.String(nullable: false, maxLength: 200),
                        ExpenseAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExpenseID);
            
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        IncomeID = c.Int(nullable: false, identity: true),
                        IncomeName = c.String(nullable: false, maxLength: 200),
                        IncomeAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IncomeDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IncomeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Incomes");
            DropTable("dbo.Expenses");
            DropTable("dbo.Accounts");
        }
    }
}
