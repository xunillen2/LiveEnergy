using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEICore.Users;
using LEICore.Sensors;

namespace LEICore.Objects
{
    /// <summary>
    /// Specifies Object class.
    /// It consists of basic Object parameters:
    /// Id, Name, City, Street, Objecttype, PredictedConsumption...
    /// But it also contains Foregin keys to Sensor that is given to Object,
    /// And User that is owner of building.
    /// </summary>
    public class Object
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public objectType ObjectType { get; set; }
        public Sensor Sensor { get; set; }
        public User User { get; set; }
        public int PredictedConsumption { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public enum objectType
    { 
        House,
        Building,
        Industry_object
    }
}
