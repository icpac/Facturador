namespace Facturador.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Facturar2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Cliente", "Nombre", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("public.Cliente", "Nombre", c => c.String());
        }
    }
}
