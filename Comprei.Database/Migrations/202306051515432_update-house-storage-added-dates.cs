namespace Comprei.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatehousestorageaddeddates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HouseStorages", "ExpirationDate", c => c.DateTime());
            AddColumn("dbo.HouseStorages", "AcquisitionDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HouseStorages", "AcquisitionDate");
            DropColumn("dbo.HouseStorages", "ExpirationDate");
        }
    }
}
