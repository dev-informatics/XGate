using System;
using System.Linq;
using XGate.Core.Contracts;

namespace XGate.Core.States
{
    public class AlwaysDisabledXGateState : IXGateState
    {
        public bool IsEnabled
        {
            get { return false; }
        }
    }
}
