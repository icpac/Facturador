namespace Facturador.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Facturar6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Documento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Serie = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.ItemDocumento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        DocumentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Documento", t => t.DocumentoId, cascadeDelete: true)
                .Index(t => t.DocumentoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.ItemDocumento", "DocumentoId", "public.Documento");
            DropIndex("public.ItemDocumento", new[] { "DocumentoId" });
            DropTable("public.ItemDocumento");
            DropTable("public.Documento");
        }
    }
}
