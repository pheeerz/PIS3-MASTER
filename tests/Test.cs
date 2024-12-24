// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PIS2;
using Assert2 = NUnit.Framework.Assert;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using NUnit.Framework;
using System.Numerics;

namespace tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestToWithSatellites()
        {
            PlanetsWithSatellites PWS = Logic.ToWithSatellites("Satellites \"ABCD EFG\" 2024.01.01 13,1435 10".Split(' '));
            PlanetsWithSatellites PWS1 = new PlanetsWithSatellites("\"ABCD EFG\" ", Convert.ToDateTime("2024.01.01"), 13.1435, 10);
            Assert.IsTrue(PWS1.Equals(PWS));


        }
        [TestMethod]
        public void TestToWithAtmosphere()
        {
            PlanetsWithAtmosphere PWA = Logic.ToWithAtmosphere("Atmosphere \"ABCD EFG\" 2024.01.01 13,1435 +".Split(' '));
            PlanetsWithAtmosphere PWA1 = new PlanetsWithAtmosphere ( "\"ABCD EFG\" ", Convert.ToDateTime("2024.01.01"), 13.1435, true );
            Assert.IsTrue(PWA1.Equals(PWA));

        }
        [TestMethod]
        public void TestPlanets()
        {
            Planets planets = Logic.ToPlanets("Planets \"ABCD EFG\" 2024.01.01 13,1435".Split(' '));
            Planets planets1 = new Planets("\"ABCD EFG\" ", Convert.ToDateTime("2024.01.01"), 13.1435);
            
            Assert.IsTrue(planets1.Equals(planets));
        }
    }
}
