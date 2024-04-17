namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "HR.Employee", name: "Depatment_ID", newName: "Dept_ID");
            RenameIndex(table: "HR.Employee", name: "IX_Depatment_ID", newName: "IX_Dept_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "HR.Employee", name: "IX_Dept_ID", newName: "IX_Depatment_ID");
            RenameColumn(table: "HR.Employee", name: "Dept_ID", newName: "Depatment_ID");
        }
    }
}
