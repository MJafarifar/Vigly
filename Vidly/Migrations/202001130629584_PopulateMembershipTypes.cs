namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {                                       
            Sql("INSERT INTO MembershipTypes (Id,Name,SignUpFee,DurationInMonths,DiscountRate) Values (1,'basic',0,0,0) ");
            Sql("INSERT INTO MembershipTypes (Id,Name,SignUpFee,DurationInMonths,DiscountRate) Values (2,'intermediate',30,1,10) ");
            Sql("INSERT INTO MembershipTypes (Id,Name,SignUpFee,DurationInMonths,DiscountRate) Values (3,'pro',90,3,15) ");
            Sql("INSERT INTO MembershipTypes (Id,Name,SignUpFee,DurationInMonths,DiscountRate) Values (4,'advanced',300,12,20) ");
        }
        
        public override void Down()
        {
        }
    }
}
