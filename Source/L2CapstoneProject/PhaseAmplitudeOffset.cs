using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2CapstoneProject
{
    class PhaseAmplitudeOffset
    {
        public double Phase { get; set; }
        public double Amplitude { get; set; }

        public PhaseAmplitudeOffset(double PhaseOffset, double AmplitudeOffset)
        {
            Phase = PhaseOffset;
            Amplitude = AmplitudeOffset;
        }
    }
}
