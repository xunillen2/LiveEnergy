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
            /* Testovi DBa */

            List<User> users = new List<User>();
            List<Sensor> sensors = new List<Sensor>();
            List<LEICore.Objects.Object> objects = new List<LEICore.Objects.Object>();
            List<ConsumptionData> consumptions = new List<ConsumptionData>();

            User u = new User();
            ConsumptionData cdatanew = new ConsumptionData();
            UserRepository userrepo = new UserRepository();
            SensorRepository srepo = new SensorRepository();
            ObjectRepository orepo = new ObjectRepository();
            ConsumptionRepository crepo = new ConsumptionRepository();


            users = userrepo.GetUsers();

            foreach (User user in users) {
                Console.WriteLine($"ID: {user.Id} FirstName: '{user.FirstName} f'");
            }

            u = userrepo.GetUser(0);
            Console.WriteLine($"ID: {u.Id} FirstName: '{u.FirstName} f'");


            sensors = srepo.GetSensors();

            Console.WriteLine("Senzori:");
            foreach (Sensor s in sensors)
            {
                Console.WriteLine($"ID: {s.Id} Name: '{s.Name} f'");
            }

            objects = orepo.GetObjects();

            Console.WriteLine("\nObjekti:");
            foreach (LEICore.Objects.Object o in objects)
            {
                Console.WriteLine($"ID: {o.Id} Name: '{o.Name}' Street: '{o.Street}' Tip: {o.ObjectType}");
                Console.WriteLine($"Sensor: '{o.Sensor.Name}' ID: {o.Sensor.Id}");
                Console.WriteLine($"User Name: '{o.User.FirstName}' Last Name: '{o.User.LastName}' UserID: {o.User.Id}");
            }

            consumptions = crepo.GetConsumptionsAll();
            Console.WriteLine("\nPotrosnja");
            foreach (ConsumptionData cdata in consumptions) {
                Console.WriteLine($"ID: {cdata.Id} type: '{cdata.ConsumptionType}', value: {cdata.ConsumptionValue}, Date: {cdata.Date}");
                Console.WriteLine($"ID: {cdata.Object.Id} Name: '{cdata.Object.Name}' Street: '{cdata.Object.Street}' Tip: {cdata.Object.ObjectType}");
            }
            consumptions = crepo.GetConsumptionsObject(2);
            Console.WriteLine("\nPotrosnja odredeni id");
            foreach (ConsumptionData cdata in consumptions)
            {
                Console.WriteLine($"ID: {cdata.Id} type: '{cdata.ConsumptionType}', value: {cdata.ConsumptionValue}, Date: {cdata.Date}");
                Console.WriteLine($"ID: {cdata.Object.Id} Name: '{cdata.Object.Name}' Street: '{cdata.Object.Street}' Tip: {cdata.Object.ObjectType}");
            }

            cdatanew = new ConsumptionData()
            {

                Id = 5,
                ConsumptionType = consumptionType.Gas,
                ConsumptionValue = 4.21321f,
                Date = DateTime.Now,
                Object = new LEICore.Objects.Object
                {
                    Id = 0,

                }
            };

            Console.WriteLine("insert test");
            crepo.InsertConsumption(cdatanew);


            Thread.Sleep(10000);

            Random random = new Random();

            Sensor senzor = new Sensor("Senzor1", 9012312);

            int port = 2222;
            //string serverip = args[0];
            SendData podatak = new SendData();

            TcpClient client = new TcpClient ("127.0.0.1", port);

            /* Popunimo vrijednosti potrosnje koje će uvijek
             * ostati iste jer ovo je samo testni program koji
             * šalje samo random potrosnju za isti objekt
             */
            podatak.Object = new LEICore.Objects.Object
            {
                Id = 324234234,
                Name = "Kuca1",
                City = "Kralovac",
                Street = "Ratimira hercega 1",
                ObjectType = objectType.Building,
                Sensor = senzor
            };
           /* podatak.Consumption = new List<ConsumptionData>();
            podatak.Consumption.Add(new ConsumptionData
            {
                ConsumptionType = ConsumptionData.ConsumptionType.struja,
            });
            podatak.Consumption.Add(new ConsumptionData
            {
                ConsumptionType = ConsumptionData.ConsumptionType.plin,
            });
            podatak.Consumption.Add(new ConsumptionData
            {
                ConsumptionType = ConsumptionData.ConsumptionType.voda,
            });

            while (true) {
                Console.WriteLine("Šaljem podatke:");
                foreach (ConsumptionData ppodatak in podatak.Potrosnja) {
                    ppodatak.KolicinaPotrosnje = random.Next(1000);
                    Console.WriteLine(ppodatak.VrstaPotrosnje + ": " +
                        ppodatak.KolicinaPotrosnje);
                }

                IFormatter formatter = new BinaryFormatter();
                NetworkStream stream = client.GetStream();

                formatter.Serialize(stream, podatak);

                stream.Close();


                // Zastoj od 5s
                Thread.Sleep(5000);*/
            }
        }
    }
