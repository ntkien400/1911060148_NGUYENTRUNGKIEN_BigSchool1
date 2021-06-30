namespace _1911060148_NGUYENTRUNGKIEN_BigSchool1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1,'Developmnet')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2,'Business')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
