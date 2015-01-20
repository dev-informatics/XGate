using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGate.EntityFramework.Models
{
    public class XFeatureGate
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public bool IsEnabled { get; protected set; }
    }
}
