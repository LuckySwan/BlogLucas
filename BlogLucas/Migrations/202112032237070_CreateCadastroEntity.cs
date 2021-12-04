namespace BlogLucas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCadastroEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Cadastro",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Name = c.String(nullable: false, maxLength: 100),
                   Endereco = c.String(nullable: false, maxLength: 400),
                   Telefone = c.Int(nullable: false),
                   DateCreated = c.DateTime(nullable: false),
                   DateUpdated = c.DateTime(),
               })
               .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Posts", new[] { "AuthorId" });
            AlterColumn("dbo.Posts", "AuthorId", c => c.Int());
            RenameColumn(table: "dbo.Posts", name: "AuthorId", newName: "Author_Id");
            CreateIndex("dbo.Posts", "Author_Id");
            AddForeignKey("dbo.Posts", "Author_Id", "dbo.Authors", "Id");
        }
    }
}
