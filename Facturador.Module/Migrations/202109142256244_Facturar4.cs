namespace Facturador.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Facturar4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("public.Producto");
            AddColumn("public.Cliente", "Correo", c => c.String(maxLength: 50));
            AddColumn("public.Producto", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("public.Producto", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("public.Producto", "Clave", c => c.String(maxLength: 40));
            AlterColumn("public.Producto", "Descripcion", c => c.String(maxLength: 100));
            AddPrimaryKey("public.Producto", "Id");
            DropColumn("public.Producto", "Oid");
        }
        
        public override void Down()
        {
            AddColumn("public.Producto", "Oid", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("public.Producto");
            AlterColumn("public.Producto", "Descripcion", c => c.String());
            AlterColumn("public.Producto", "Clave", c => c.String());
            DropColumn("public.Producto", "Precio");
            DropColumn("public.Producto", "Id");
            DropColumn("public.Cliente", "Correo");
            AddPrimaryKey("public.Producto", "Oid");
        }
    }
}
