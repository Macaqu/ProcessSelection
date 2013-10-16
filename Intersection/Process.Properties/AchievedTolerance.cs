using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process.Process.Properties
{
    public class AchievedTolerance<T> : List<T> where T : AchievedToleranceMaterial
    {
        public AchievedTolerance() { }
    }

    public class AchievedToleranceMaterial
    {
        public string MeasureSize{ get {return "%";}}

        public AchievedToleranceMaterial(string material, double percentage) {
            if (percentage > 100) {
                throw new ArgumentOutOfRangeException("percentage should be less or equal 100");
            }

            if(percentage < 0){
                throw new ArgumentOutOfRangeException("percentage should be more or equal 0");
            }
            
            Material = material;
            Percentage = percentage;
        }

        public string Material { get; set; }

        public double Percentage { get; set; }
    }
}
