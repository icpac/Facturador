namespace Facturador.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Facturar3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("public.Cliente");
            AddColumn("public.Cliente", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("public.Cliente", "Id");
            DropColumn("public.Cliente", "Oid");
        }
        
        public override void Down()
        {
            AddColumn("public.Cliente", "Oid", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("public.Cliente");
            DropColumn("public.Cliente", "Id");
            AddPrimaryKey("public.Cliente", "Oid");
        }
    }
}
