using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using LEICore;
using LEICore.Objects;
using LEICore.Users;
using LEICore.Sensors;
using LEICore.Consumption;
using static LEICore.Consumption.ConsumptionData;

/*
O programu:
Program simulira senzor koji šalje podatke na CRA za određen objekt.
 */

namespace LESensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LEICore.Objects.Object> objects = new List<LEICore.Objects.Object>();
            List<ConsumptionData> consumptions = new List<ConsumptionData>();

            ConsumptionData cdatanew = new ConsumptionData();
            ObjectRepository orepo = new ObjectRepository();
            ConsumptionRepository crepo = new ConsumptionRepository();
            Random rnd = new Random();

            int tempIdConsumption = 0;
            int maxIdObject = 0;

            tempIdConsumption = ++crepo.GetConsumptionMaxId().Id;
            maxIdObject = orepo.GetObjectMaxId().Id;
            while (true)
            {
                cdatanew = new ConsumptionData()
                {
                    Id = tempIdConsumption,
                    ConsumptionType = (consumptionType)rnd.Next(0, 3),
                    ConsumptionValue = rnd.Next(0, 200),
                    Date = DateTime.Now,
                    Object = new LEICore.Objects.Object
                    {
                        Id = rnd.Next(0, maxIdObject),

                    }
                };
                tempIdConsumption++;
                Thread.Sleep(50);
                crepo.InsertConsumption(cdatanew);
            }

        }
    }
}
