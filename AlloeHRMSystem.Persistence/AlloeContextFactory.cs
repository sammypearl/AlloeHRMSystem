using AlloeHRMSystem.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlloeHRMSystem.Persistence
{
    public class AlloeContextFactory : DesignTimeDbContextFactoryBase<AlloeContext>
    {
        protected override AlloeContext CreateNewInstance(DbContextOptions<AlloeContext> options)
        {
            return new AlloeContext(options);
        }
    }
}
