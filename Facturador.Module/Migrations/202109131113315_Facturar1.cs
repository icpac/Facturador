namespace Facturador.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Facturar1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Cliente", "Rfc", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("public.Cliente", "Rfc", c => c.String());
        }
    }
}
