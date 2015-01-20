using System;
using System.Data.Entity;
using System.Linq;
using XGate.EntityFramework.Models;

namespace XGate.EntityFramework
{
    public class XGateDbContext : DbContext
    {
        public DbSet<XFeatureGate> XFeatureGates { get; set; }
    }
}
