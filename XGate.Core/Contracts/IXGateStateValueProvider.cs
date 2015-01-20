using System;
using System.Linq;

namespace XGate.Core.Contracts
{
    public interface IXGateStateValueProvider
    {
        bool IsEnabled(IXGate featureGate);
    }
}
