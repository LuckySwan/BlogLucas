namespace BlogLucas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCadastroEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            RenameColumn(table: "dbo.Posts", name: "Author_Id", newName: "AuthorId");
            AlterColumn("dbo.Posts", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "AuthorId");
            AddForeignKey("dbo.Posts", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
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
