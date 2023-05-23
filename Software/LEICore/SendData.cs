using System.Collections.Generic;
using LEICore.Objects;
using LEICore.Consumption;

namespace LEICore
{
    public class SendData
    {
        public Object Object { get; set; }
        public List<ConsumptionData> Consumption { get; set; }

    }
}
