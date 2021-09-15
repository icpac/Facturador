namespace Facturador.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Documento", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("public.Documento", "ClienteId");
            AddForeignKey("public.Documento", "ClienteId", "public.Cliente", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("public.Documento", "ClienteId", "public.Cliente");
            DropIndex("public.Documento", new[] { "ClienteId" });
            DropColumn("public.Documento", "ClienteId");
        }
    }
}
