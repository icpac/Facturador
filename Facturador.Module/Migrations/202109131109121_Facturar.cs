namespace Facturador.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Facturar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Cliente",
                c => new
                    {
                        Oid = c.String(nullable: false, maxLength: 128),
                        Rfc = c.String(),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "public.Empresa",
                c => new
                    {
                        Oid = c.String(nullable: false, maxLength: 128),
                        Rfc = c.String(),
                        Nombre = c.String(),
                        Regimen = c.String(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "public.Producto",
                c => new
                    {
                        Oid = c.String(nullable: false, maxLength: 128),
                        Clave = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Oid);
            
        }
        
        public override void Down()
        {
            DropTable("public.Producto");
            DropTable("public.Empresa");
            DropTable("public.Cliente");
        }
    }
}
