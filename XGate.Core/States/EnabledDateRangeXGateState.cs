using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGate.Core.Contracts;

namespace XGate.Core.States
{
    public class EnabledDateRangeXGateState : IXGateState
    {
        private readonly DateTime _from;
        private readonly DateTime _to;
        private readonly bool _isUtc;

        public EnabledDateRangeXGateState(DateTime from, DateTime to, bool isUtc = false)
        {
            _from = from;
            _to = to;
            _isUtc = isUtc;
        }

        public bool IsEnabled
        {
            get 
            {  
                DateTime now = _isUtc ? DateTime.UtcNow : DateTime.Now;
                return (now >= _from && now <= _to);
            }
        }
    }
}
