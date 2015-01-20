using System;
using System.Linq;
using XGate.Core.Contracts;

namespace XGate.EntityFramework
{
    public class EntityFrameworkValueProvider : IXGateStateValueProvider    
    {
        private readonly XGateDbContext _context;

        public EntityFrameworkValueProvider(XGateDbContext dbContext)
        {
            _context = dbContext;
        }

        public bool IsEnabled(IXGate featureGate)
        {
            var featureGateValue =_context.XFeatureGates.FirstOrDefault(feat => feat.Name == featureGate.GetType().Name);
            if (featureGateValue == null)
                throw new NullReferenceException("featureGateValue.");

            return featureGateValue.IsEnabled;
        }
    }
}
