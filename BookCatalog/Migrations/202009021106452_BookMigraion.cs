namespace BookCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookMigraion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Author_Name = c.String(),
                        Nationality = c.String(),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author_Id = c.Int(nullable: false),
                        Release_Date = c.String(),
                        price = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Authors", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Books", "Author_Id", "public.Authors");
            DropIndex("public.Books", new[] { "Author_Id" });
            DropTable("public.Books");
            DropTable("public.Authors");
        }
    }
}
