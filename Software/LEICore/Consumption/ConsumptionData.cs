using System;

namespace LEICore.Consumption
{
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
