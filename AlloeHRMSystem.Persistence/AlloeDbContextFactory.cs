//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AlloeHRMSystem.Persistence
//{
//    public class AlloeDbContextFactory : IDesignTimeDbContextFactory<AlloeContext>
//    {
//        public static string DataConnectionString => new DatabaseConfiguration().GetDataConnectionString();
//        public AlloeContext CreateDbContext(string[] args)
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<AlloeContext>();

//            optionsBuilder.UseSqlServer<AlloeContext>(DataConnectionString);

//            return new AlloeContext(optionsBuilder.Options);
//        }
//    }

   
//}
