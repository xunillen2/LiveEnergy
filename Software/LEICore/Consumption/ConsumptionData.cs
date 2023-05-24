using System;

namespace LEICore.Consumption
{
    /// <summary>
    /// Specifies Consumption for Objects.
    /// It contains ID, Consumption Value, Consumption Type and Date.
    /// and Foregin key Object
    /// </summary>
    public class ConsumptionData
    {
        public int Id { get; set; }
        public consumptionType ConsumptionType{ get; set; }
        public float ConsumptionValue { get; set; }
        public Objects.Object Object { get; set; }
        public DateTime Date { get; set; }

        public enum consumptionType { 
            Gas,
            Water,
            Electricity
        }
    }
}
