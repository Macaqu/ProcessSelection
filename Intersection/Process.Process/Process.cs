using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Process.Process.Properties;

namespace Process.Process.Process
{
    public class Process
    {
        public Process(string processName) {
            ProcessName = processName;
        }

        public string ProcessName { get; set; }

        public EnvelopeSize EvelopeSize { get; set; }

        public AchievedSurfaceRoughness SurfaceRoughness { get; set; }

        public Thickness<ThicknessMaterial> Thickness { get; set; }

        public AchievedTolerance<AchievedToleranceMaterial> Tolerance { get; set; }
    }
}
