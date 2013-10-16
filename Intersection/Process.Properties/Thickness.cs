using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process.Process.Properties
{
    public class Thickness<T> : List<T> where T : ThicknessMaterial
    {
        public Thickness() { }

    }


    /// <summary>
    /// Members of Thickness
    /// 
    /// </summary>
    public class ThicknessMaterial 
    {

        private string material;

        public ThicknessMaterial(string material, double minRange, double maxRange) { 
            
            MinRange = minRange;
            MaxRange = maxRange;
        }

        public string Material { 
            get { 
                if (material == string.Empty) {
                    return string.Empty;
                }
                return material;
            }
            set { 
                material = value;
            }
        }

        public string StandardMeasure { get { return "mm"; } }

        public double MinRange { get; set; }

        public double MaxRange { get; set; }
    }
}
