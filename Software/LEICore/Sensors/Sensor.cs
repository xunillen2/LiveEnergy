using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEICore.Sensors
{
    public class Sensor
    {
        public Sensor()
        {
        }
        public Sensor(string name, uint id) {
            this.Name = name;
            this.Id = id;
        }
        
        public string Name { get; set; }
        public uint Id { get; set; }


        public override string ToString() {
            return Name;
        }
    }
}
