using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Tech
    {
        public static List<double> LowerPlaces = new List<double>()
        {
            0.018,0.065,0.075,0.080,0.027,0.018,0.105,0.115,
            0.8,1.25,0.8,0.125,0.01,0.01
        };
        public static List<double> HigherPlaces = new List<double>()
        {
            0.026,0.09,0.105,0.115,0.027,0.026,0.135,0.150,
            1.5,2d,1.5,0.185,0.02,0.015
        };
        public double WealthyResistance { get; set; }
        public double PovertyResistance { get; set; }
        public double HotResistance { get; set; }
        public double ColdResistance { get; set; }
        public double AridResistance { get; set; }
        public double HumidResistance { get; set; }
        public double UrbanResistance { get; set; }
        public double RuralResistance { get; set; }
        public double Infectivity { get; set; }
        public double Severity { get; set; }
        public double Lethality { get; set; }
        public double Mutation { get; set; }
        public double CureBaseMultiplier { get; set; }
        public double ResearchInefficiency { get; set; }
        public int Cost { get; set; }
        public double Degree { get; set; }
        public Tech()
        {
            WealthyResistance = 0;
            PovertyResistance = 0;
            HotResistance = 0;
            ColdResistance = 0;
            AridResistance = 0;
            HumidResistance = 0;
            UrbanResistance = 0;
            RuralResistance = 0;
            Infectivity = 0;
            Severity = 0;
            Lethality = 0;
            Mutation = 0;
            CureBaseMultiplier = 0;
            ResearchInefficiency = 0;
            Cost = 0;
            Degree = 0;
        }
        public int GetLowerCost()
        {
            double tmpCost = (WealthyResistance / HigherPlaces[0])
                             + (PovertyResistance / HigherPlaces[1])
                             + (UrbanResistance / HigherPlaces[2])
                             + (RuralResistance / HigherPlaces[3])
                             + (ColdResistance / HigherPlaces[4])
                             + (HotResistance / HigherPlaces[5])
                             + (AridResistance / HigherPlaces[6])
                             + (HumidResistance / HigherPlaces[7])
                             + (Infectivity / HigherPlaces[8])
                             + (Severity / HigherPlaces[9])
                             + (Lethality / HigherPlaces[10])
                             + (Mutation / HigherPlaces[11])
                             + (CureBaseMultiplier / HigherPlaces[12])
                             + (ResearchInefficiency / HigherPlaces[13]);
            return (int)tmpCost;
        }
        public int GetHigherCost()
        {
            double tmpCost = (WealthyResistance / LowerPlaces[0])
                             + (PovertyResistance / LowerPlaces[1])
                             + (UrbanResistance / LowerPlaces[2])
                             + (RuralResistance / LowerPlaces[3])
                             + (ColdResistance / LowerPlaces[4])
                             + (HotResistance / LowerPlaces[5])
                             + (AridResistance / LowerPlaces[6])
                             + (HumidResistance / LowerPlaces[7])
                             + (Infectivity / LowerPlaces[8])
                             + (Severity / LowerPlaces[9])
                             + (Lethality / LowerPlaces[10])
                             + (Mutation / LowerPlaces[11])
                             + (CureBaseMultiplier / LowerPlaces[12])
                             + (ResearchInefficiency / LowerPlaces[13]);
            return (int)tmpCost;
        }
    }
}
