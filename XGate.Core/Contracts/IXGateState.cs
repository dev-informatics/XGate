using System;
using System.Linq;

namespace XGate.Core.Contracts
{
    public interface IXGateState
    {
        bool IsEnabled { get; }
    }
}
