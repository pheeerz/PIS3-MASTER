using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    public class Logic
    {
        public static PlanetsWithSatellites ToWithSatellites(string[] inputItems)
        {
            try
            {
                if (inputItems[0] == "Satellites")
                {
                    string Name = "";
                    DateTime OpeningDate = Convert.ToDateTime(inputItems[inputItems.Length - 3]);
                    double Radius = Convert.ToDouble(inputItems[inputItems.Length - 2]);

                    for (int x = 1; x < inputItems.Length - 3; x++)
                    {
                        Name += inputItems[x] + " ";
                    }
                    // Console.WriteLine("Сколько у этой планеты спутников?");
                    // int CounterOfSatellites = Convert.ToInt32(Console.ReadLine());
                    int CounterOfSatellites = Convert.ToInt32(inputItems[inputItems.Length - 1]);

                    return new PlanetsWithSatellites(Name, OpeningDate, Radius, CounterOfSatellites);
                }
            }
            catch(Exception ex)
            {
                new Exception("Во время выполнения программы возникла ошибка");
            }
            return null;
        }

        public static PlanetsWithAtmosphere ToWithAtmosphere(string[] inputItems)
        {
            try
            {
                if (inputItems[0] == "Atmosphere")
                {
                    string Name = "";
                    DateTime OpeningDate = Convert.ToDateTime(inputItems[inputItems.Length - 3]);
                    double Radius = Convert.ToDouble(inputItems[inputItems.Length - 2]);

                    for (int x = 1; x < inputItems.Length - 3; x++)
                    {
                        Name += inputItems[x] + " ";
                    }
                    string atmos = inputItems[inputItems.Length-1];
                    bool Atmosphere = false;
                    if (atmos == "+")
                    {
                        Atmosphere = true;
                    }
                    return new PlanetsWithAtmosphere(Name, OpeningDate, Radius, Atmosphere);
                }
            }
            catch(Exception ex)
            {
                new Exception("Во время выполнения программы возникла ошибка");
            }
            return null;
        }
        public static Planets ToPlanets(string[] inputItems)
        {
            try
            {
                if (inputItems[0] == "Planets")
                {


                    string Name = "";
                    DateTime OpeningDate = Convert.ToDateTime(inputItems[inputItems.Length - 2]);
                    double Radius = Convert.ToDouble(inputItems[inputItems.Length - 1]);

                    for (int x = 1; x < inputItems.Length - 2; x++)
                    {
                        Name += inputItems[x] + " ";
                    }

                    return new Planets(Name, OpeningDate, Radius);
                }
            }
            catch(Exception ex)
            {
                new Exception("Во время выполнения программы возникла ошибка");
            }
            return null;
        }
    }
}
