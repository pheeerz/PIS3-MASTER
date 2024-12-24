using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace PIS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название класса и его свойства");

            string[] inputItems = "Planets \"Q W E   R TY\" 2024.01.01 13,1435".Split(' ');

            //string[] inputItems = File.ReadAllText("../../Test.txt").Split(' ');

            Planets planets = Logic.ToPlanets(inputItems);
            Console.WriteLine(planets.name);
            Console.WriteLine(planets.openingDate);
            Console.WriteLine(planets.radius);

            
            PlanetsWithAtmosphere atmos = Logic.ToWithAtmosphere(inputItems);
            PlanetsWithSatellites satellites = Logic.ToWithSatellites(inputItems);


            // Console
            Console.WriteLine($"\nАтмосфера: {atmos.atmosphere}\n");
            Console.WriteLine($"Кол-во спутников: {satellites.counterOfSatellites}\n");
        } 
    }
}
