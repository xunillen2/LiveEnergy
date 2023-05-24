using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEICore.Sensors
{
    /// <summary>
    /// Specifies Sensor Object.
    /// Contains Id and Name
    /// </summary>
    public class Sensor
    {   
        public string Name { get; set; }
        public uint Id { get; set; }


        public override string ToString() {
            return Name;
        }
    }
}
