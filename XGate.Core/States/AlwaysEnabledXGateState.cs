using System;
using System.Linq;
using XGate.Core.Contracts;

namespace XGate.Core.States
{
    public class AlwaysEnabledXGateState : IXGateState
    {
        public bool IsEnabled
        {
            get { return true; }
        }
    }
}
